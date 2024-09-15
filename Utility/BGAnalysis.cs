using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



public class BGAnalysis
{
    private static BGAnalysis _instance = null;
    public static BGAnalysis Ins
    {
        get
        {
            if (_instance == null)
                _instance = new BGAnalysis();
            return _instance;
        }
    }

    public int MaxSingleFileBGNum;

    public void Analysis(string analysisPath)
    {
        MaxSingleFileBGNum = SaveManager.Ins.data.MaxSingleFileBGNum;

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(analysisPath);

        StringBuilder manifest = new StringBuilder();
        int allFileNum = 0;

        //迭代创建索引文件，一个文件夹的索引文件在其内部，且与文件夹同名
        //索引文件每100个分为一组
        while(queue.Count > 0)
        {
            string path = queue.Dequeue();
            path = path.Replace("\\", "/");
            string name = Path.GetFileName(path);

            //当前文件夹内的的所有壁纸文件路径
            List<string> filePaths = GetAllImagePath(path);

            //先删除所有txt文件，因为接下来需要创建用于标识当前壁纸路径的txt文件，不需要其他多余的或者上次残留的
            string[] remainTxtPaths = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < remainTxtPaths.Length; i++)
            {
                File.Delete(remainTxtPaths[i]);
            }

            //创建并写入文件中，壁纸按每100个分一组
            StringBuilder stringBuilder = new StringBuilder();

            //壁纸分组创建文件
            int curFileIndex = -1;
            for (int i = 0; i < filePaths.Count; i++)
            {
                //每一百个进行一次操作
                if (i % MaxSingleFileBGNum == 0)
                {
                    if (curFileIndex != -1)
                    {
                        string tmp = path + "/" + name + "-" + curFileIndex + ".txt";
                        stringBuilder.Insert(0, MaxSingleFileBGNum + "\n");
                        manifest.AppendLine(tmp);
                        allFileNum++;
                        File.WriteAllText(tmp, stringBuilder.ToString());
                        stringBuilder.Clear();
                    }
                    curFileIndex++;
                }

                stringBuilder.AppendLine(filePaths[i].Replace("\\", "/"));
            }

            //循环完成后不满100个的部分再创建一个文件
            if (stringBuilder.Length > 0)
            {
                string tmp = path + "/" + name + "-" + curFileIndex + ".txt";
                stringBuilder.Insert(0, (filePaths.Count % MaxSingleFileBGNum == 0 ? MaxSingleFileBGNum : filePaths.Count % MaxSingleFileBGNum) + "\n");
                manifest.AppendLine(tmp);
                allFileNum++;
                File.WriteAllText(tmp, stringBuilder.ToString());
                stringBuilder.Clear();
            }

            //迭代操作，迭代子文件
            string[] folderPaths = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly)
                .OrderBy(x => x, new CustomDirectoryComparer())
                .ToArray();
            for(int i = 0; i < folderPaths.Length; i++)
                queue.Enqueue(folderPaths[i]);
        }

        manifest.Insert(0, allFileNum + "\n");
        File.WriteAllText(analysisPath.Replace("\\", "/") + "/" + Path.GetFileName(analysisPath) + ".txt", manifest.ToString());
    }

    public List<string> GetAllImagePath(string path)
    {
        List<string> filePaths = new List<string>();
        string[] extensions = { "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp" };
        foreach (string extension in extensions)
        {
            string[] files = Directory.GetFiles(path, extension, SearchOption.TopDirectoryOnly);
            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    filePaths.Add(file);
                }
            }
        }

        return filePaths;
    }

    public void ClearAllTxt(string analysisPath)
    {
        string[] txts = Directory.GetFiles(analysisPath, "*.txt", SearchOption.AllDirectories);
        foreach (string txt in txts)
        {
            File.Delete(txt);
        }
    }

    public List<string> GetPaths(string txtPath)
    {
        List<string> strings = new List<string>();
        using (StreamReader sr = new StreamReader(txtPath, new UTF8Encoding()))
        {
            int count = int.Parse(sr.ReadLine());
            for(int i = 0; i < count; i++)
            {
                strings.Add(sr.ReadLine());
            }
        }
        return strings;
    }

    public void WriteTxt(string txtPath, string content)
    {
        if (File.Exists(txtPath))
            File.Delete(txtPath);
        File.WriteAllText(txtPath, content);
    }
}

class CustomDirectoryComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        var xNumbers = ExtractNumbers(Path.GetFileName(x));
        var yNumbers = ExtractNumbers(Path.GetFileName(y));

        int maxLength = Math.Max(xNumbers.Count, yNumbers.Count);

        for (int i = 0; i < maxLength; i++)
        {
            int xNumber = i < xNumbers.Count ? xNumbers[i] : 0;
            int yNumber = i < yNumbers.Count ? yNumbers[i] : 0;

            int comparison = xNumber.CompareTo(yNumber);
            if (comparison != 0)
                return comparison;
        }

        return 0;
    }

    private List<int> ExtractNumbers(string fileName)
    {
        var numbers = new List<int>();
        var matches = Regex.Matches(fileName, @"\d+");

        foreach (Match match in matches)
        {
            numbers.Add(int.Parse(match.Value));
        }

        return numbers;
    }
}