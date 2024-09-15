using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

public class VSCSettings
{
    private static VSCSettings _instance;
    public static VSCSettings Ins
    {
        get
        {
            if(_instance == null)
                _instance = new VSCSettings();
            return _instance;
        }
    }

    private string settingsPath;

    public void SetBackgroundList(string paths)
    {
        settingsPath = SaveManager.Ins.data.settingsPath;
        var obj = JObject.Parse(SaveManager.ReadJson(settingsPath));

        obj["background.customImages"] = JArray.Parse(paths);

        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        SaveManager.WriteJson(json, settingsPath);
    }
    public void SetSingleInterval(int singleInterval)
    {
        settingsPath = SaveManager.Ins.data.settingsPath;
        var obj = JObject.Parse(SaveManager.ReadJson(settingsPath));

        obj["background.interval"] = singleInterval;

        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        SaveManager.WriteJson(json, settingsPath);
    }

    public void SetBackgroundAlignStyle(string alignTypeCode)
    {
        settingsPath = SaveManager.Ins.data.settingsPath;
        var obj = JObject.Parse(SaveManager.ReadJson(settingsPath));

        obj["background.style"]["background-position"] = alignTypeCode;

        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        SaveManager.WriteJson(json, settingsPath);
    }

    public void SetbackgroundRepeatType(string repeatTypeCode)
    {
        settingsPath = SaveManager.Ins.data.settingsPath;
        var obj = JObject.Parse(SaveManager.ReadJson(settingsPath));

        obj["background.style"]["background-repeat"] = repeatTypeCode;

        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        SaveManager.WriteJson(json, settingsPath);
    }
}
