using System;
using System.Windows.Forms;

public class TimerManager
{
    public Timer groupTimer;
    public int seconds;
    private System.Action onCompleted;

    public Action<int> onTick;

    private static TimerManager _instance;
    public static TimerManager Ins
    {
        get
        {
            if(_instance == null )
                _instance = new TimerManager();
            return _instance;
        }
    }

    public void Init(Timer timer, System.Action callBack)
    {
        groupTimer = timer;
        groupTimer.Tick += Tick;
        onCompleted = callBack;
        groupTimer.Stop();
    }

    public void Start(int amountSeconds)
    {
        Console.WriteLine("Start");

        if (amountSeconds < 1)
            return;

        seconds = amountSeconds;
        groupTimer.Start();
    }

    public void Stop()
    {
        seconds = 0;
        groupTimer.Stop();
    }

    public void Tick(object sender, EventArgs args)
    {
        seconds--;

        onTick?.Invoke(seconds);

        if (seconds <= 0)
        {
            groupTimer.Stop();
            if (onCompleted != null)
                onCompleted.Invoke();
        }
    }
}
