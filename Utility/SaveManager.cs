﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

[Serializable]
public class Data
{
    public string analysisPath = "";
    public string settingsPath = "C:\\Users\\Administrator\\AppData\\Roaming\\Code\\User\\settings.json";
    public string usedPath = "";
    public int MaxSingleFileBGNum = 100;
    public int previewImgNum = 6;
    public int singleInterval = 300;
    public float groupInterval = 60;
    public bool isAutoRandom = false;
    public bool isSlideShow = false;
    public int AlignType = 1;
    public int RpeatType = 0;
    public int OpacityPercent = 30;

    public bool isAnalysised = false;
    public bool useEnglish = false;
    public bool useFront = false;
}

public class SaveManager
{
    private static SaveManager _instance = null;
    public static SaveManager Ins
    {
        get
        {
            if (_instance == null)
                _instance = new SaveManager();
            return _instance;
        }
    }

    public Data data = new Data();

    public const string SavePath = "C:/Program Files/VSC-BGSettings-GUI";
    public const string SaveFile = "settings.json";

    public void SaveData()
    {
        if(!Directory.Exists(SavePath))
            Directory.CreateDirectory(SavePath);

        string saveFullPath = SavePath + "/" + SaveFile;

        if(File.Exists(saveFullPath))
            File.Delete(saveFullPath);

        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(saveFullPath, json);
    }

    public void ReadData()
    {
        if (!Directory.Exists(SavePath))
            return;

        string saveFullPath = SavePath + "/" + SaveFile;

        if (!File.Exists(saveFullPath))
            return;

        data = JsonConvert.DeserializeObject<Data>(ReadJson(saveFullPath));
    }

    public static string ReadJson(string jsonPath)
    {
        using (StreamReader sr = new StreamReader(jsonPath, new UTF8Encoding()))
        {
            return sr.ReadToEnd();
        }
    }

    public static void WriteJson(string content, string jsonPath)
    {
        if (File.Exists(jsonPath))
            File.Delete(jsonPath);
        File.WriteAllText(jsonPath, content);
    }

    public string GetManifestPath()
    {
        if (string.IsNullOrEmpty(data.analysisPath))
            return null;
        return data.analysisPath.Replace("\\", "/") + "/" + Path.GetFileName(data.analysisPath) + ".txt";
    }
}
