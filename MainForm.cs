using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VSC_BackgroundSetting
{
    public partial class MainForm : Form
    {
        private string selectedTextPath;
        private string usedTextPath;

        private bool isSlideShow;
        private bool isAutoRandom;

        private int aliginType;
        private int repeatType;
        private int opacityPercent;
        
        private int previewImgNum;
        private int singleInterval;
        private float groupInterval;

        public static bool isAnalysised = false;

        public bool useEnglish = false;
        public bool useFront = false;

        public MainForm()
        {
            InitializeComponent();

            ReadData();

            UpdateGrid();

            UpdatePreview();

            InitGridAction();
        }

        private void ReadData()
        {
            useEnglish = SaveManager.Ins.data.useEnglish;
            if (useEnglish)
                Btn_SwitchLanguage_Click(null, null);

            //读取并缓存存储的数据
            usedTextPath = SaveManager.Ins.data.usedPath;
            previewImgNum = SaveManager.Ins.data.previewImgNum;
            singleInterval = SaveManager.Ins.data.singleInterval;
            groupInterval = SaveManager.Ins.data.groupInterval;
            isAutoRandom = SaveManager.Ins.data.isAutoRandom;
            isSlideShow = SaveManager.Ins.data.isSlideShow;
            aliginType = SaveManager.Ins.data.AlignType;
            repeatType = SaveManager.Ins.data.RpeatType;
            opacityPercent = SaveManager.Ins.data.OpacityPercent;
            isAnalysised = SaveManager.Ins.data.isAnalysised;
            useFront = SaveManager.Ins.data.useFront;
            //强制更新，保证写入VSCode的Json文件内
            CB_UseFront_CheckedChanged(null, null);

            //初始化定时器，用于定时切换
            TimerManager.Ins.Init(SlideShowTimer, OnTimerCompleted);
            TimerManager.Ins.onTick += OnTick;

            //将存储的数据显示在界面上
            TB_TargetPath.Text = SaveManager.Ins.data.analysisPath;
            TB_settingsPath.Text = SaveManager.Ins.data.settingsPath;
            TB_MaxBGgroupNum.Text = SaveManager.Ins.data.MaxSingleFileBGNum.ToString();

            TB_CurUsedGroup.Text = usedTextPath;
            TB_previewImgNum.Text = previewImgNum.ToString();
            TB_SingleInterval.Text = ((float)singleInterval / 60).ToString();
            TB_GroupInterval.Text = groupInterval.ToString();

            CB_IsAutoRandom.Checked = isAutoRandom;
            CB_IsSlideShow.Checked = isSlideShow;

            CB_AlignType.SelectedIndex = aliginType;
            CB_RepeatType.SelectedIndex = repeatType;
            TB_Opacity.Text = opacityPercent.ToString();

            CB_UseFront.Checked = useFront;

            //没有解析则停止计时
            if (!isAnalysised)
                TimerManager.Ins.Stop();
        }

        #region Analysis
        private void Btn_SelectTargetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = TB_TargetPath.Text;
            dialog.Description  = "请选择需要解析的目标根文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取选择路径
                TB_TargetPath.Text = dialog.SelectedPath;

                //选择后立刻判断是否已经被解析过，是则立即更新
                string manifestPath = GetManifestPath();
                if(!File.Exists(manifestPath))
                    return;

                //没有任何活跃的分析文件时，立即存储为当前值
                if (!SaveManager.Ins.data.isAnalysised)
                {
                    SaveManager.Ins.data.isAnalysised = true;
                    SaveManager.Ins.data.analysisPath = TB_TargetPath.Text;
                    SaveManager.Ins.SaveData();
                }

                isAnalysised = true;

                //更新图表
                UpdateGrid();
            }
        }

        private void TB_TargetPath_TextChanged(object sender, EventArgs e)
        {
            string manifestPath = GetManifestPath();
            if (!File.Exists(manifestPath))
                return;

            //没有任何活跃的分析文件时，立即存储为当前值
            if (!SaveManager.Ins.data.isAnalysised)
            {
                SaveManager.Ins.data.isAnalysised = true;
                SaveManager.Ins.data.analysisPath = TB_TargetPath.Text;
                SaveManager.Ins.SaveData();
            }

            isAnalysised = true;

            UpdateGrid();
        }

        private void Btn_SelectSettingsPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = TB_settingsPath.Text;
            dialog.Title  = "请选择VSCode的settings.json文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TB_settingsPath.Text = dialog.FileName;

                SaveManager.Ins.data.settingsPath = dialog.FileName;
                SaveManager.Ins.SaveData();
            }
        }

        private void TB_settingsPath_TextChanged(object sender, EventArgs e)
        {
            SaveManager.Ins.data.settingsPath = TB_settingsPath.Text;
            SaveManager.Ins.SaveData();
        }

        private void Btn_Analysis_Click(object sender, EventArgs e)
        {
            if (TB_TargetPath.Text == "")
            {
                MessageBox.Show("你必须指定需要解析的壁纸文件根目录", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tmp = TB_TargetPath.Text;
            if (tmp == tmp[0] + ":/" || tmp == tmp[0] + ":\\")
            {
                MessageBox.Show("安全起见，禁止使用根目录作为解析文件目录！", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //没有任何活跃的分析文件时，立即存储为当前值
            if(!SaveManager.Ins.data.isAnalysised)
            {
                SaveManager.Ins.data.analysisPath = TB_TargetPath.Text;
                SaveManager.Ins.SaveData();
            }

            BGAnalysis.Ins.Analysis(TB_TargetPath.Text);

            isAnalysised = true;
            SaveManager.Ins.data.isAnalysised = true;
            SaveManager.Ins.SaveData();

            UpdateGrid();
        }

        private void Btn_ClearTxt_Click(object sender, EventArgs e)
        {
            if (TB_TargetPath.Text == "")
            {
                MessageBox.Show("你必须指定需要清空的壁纸文件根目录", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tmp = TB_TargetPath.Text;
            if (tmp == tmp[0] + ":/" || tmp == tmp[0] + ":\\")
            {
                MessageBox.Show("安全起见，禁止使用根目录作为清空文件目录！", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BGAnalysis.Ins.ClearAllTxt(TB_TargetPath.Text);

            dataGrid.Rows.Clear();
            imgList.Images.Clear();
            imgPreview.Items.Clear();

            TB_CurSelectedGroup.Text = "";
            selectedTextPath = "";

            //允许用户清除非活动文件夹的解析文件而不影响正在运行的文件夹
            if (TB_TargetPath.Text != SaveManager.Ins.data.analysisPath)
                return;

            SaveManager.Ins.data.usedPath = "";
            usedTextPath = "";

            SaveManager.Ins.data.isAnalysised = false;
            isAnalysised = false;

            TB_CurUsedGroup.Text = "";
            TB_RemainGroupTimes.Text = "";

            SaveManager.Ins.SaveData();

            TimerManager.Ins.Stop();
        }

        private void TB_MaxBGgroupNum_TextChanged(object sender, EventArgs e)
        {
            BGAnalysis.Ins.MaxSingleFileBGNum = int.Parse(TB_MaxBGgroupNum.Text);

            SaveManager.Ins.data.MaxSingleFileBGNum = BGAnalysis.Ins.MaxSingleFileBGNum;
            SaveManager.Ins.SaveData();
        }
        #endregion

        #region Grid
        private void UpdateGrid()
        {
            dataGrid.Rows.Clear();

            string manifestPath = GetManifestPath();
            if (!File.Exists(manifestPath))
                return;

            int startIndex = TB_TargetPath.Text.Length - Path.GetFileName(TB_TargetPath.Text).Length;
            using(StreamReader sr1 = new StreamReader(manifestPath, new UTF8Encoding()))
            {
                int count = int.Parse(sr1.ReadLine());
                for(int i = 0; i < count; i++)
                {
                    string path = sr1.ReadLine();
                    int num;
                    using(StreamReader sr2 = new StreamReader(path, new UTF8Encoding()))
                    {
                        num = int.Parse(sr2.ReadLine());
                    }
                    path = path.Substring(startIndex, path.LastIndexOf('.') - startIndex);
                    dataGrid.Rows.Add(new object[] { path, num });
                }
            }
        }

        private void OnGridSelecteChanged(object sender, EventArgs e)
        {
            if (!isAnalysised)
                return;

            var cell = dataGrid.SelectedCells;

            if (cell == null || cell.Count <= 0)
                return;

            string displayPath = (string)dataGrid.Rows[cell[0].RowIndex].Cells[0].Value;
            string fullPath = displayPathToRealPath(displayPath);

            selectedTextPath = fullPath;
            TB_CurSelectedGroup.Text = displayPath;

            UpdatePreview();
        }

        private void InitGridAction()
        {
            dataGrid.SelectionChanged += OnGridSelecteChanged;

            //选择正在使用的
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if ((string)dataGrid.Rows[i].Cells[0].Value == usedTextPath)
                {
                    dataGrid.Rows[i].Cells[0].Selected = true;
                    break;
                }
            }
        }
        #endregion

        #region Preview
        private void UpdatePreview()
        {
            //尽量减少内存浪费
            foreach (Image img in imgList.Images)
                img.Dispose();
            imgList.Images.Clear();
            imgPreview.Items.Clear();

            if (string.IsNullOrEmpty(selectedTextPath))
                return;

            //图片列表
            List<string> bgs = BGAnalysis.Ins.GetPaths(selectedTextPath);
            //加到图片列表
            int need = Math.Min(previewImgNum, bgs.Count);
            for (int i = 0; i < need; i++)
            {
                Image image = GetImage(bgs[i]);
                if (image == null)
                    break;
                imgList.Images.Add(image);
                imgPreview.Items.Add("", i);
            }

            GC.Collect();
        }
        private void TB_previewImgNum_TextChanged(object sender, EventArgs e)
        {
            previewImgNum = int.Parse(TB_previewImgNum.Text);
            SaveManager.Ins.data.previewImgNum = previewImgNum;
            SaveManager.Ins.SaveData();
        }
        static Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return bitmap;
        }
        private Image GetImage(string imagePath, int tryCount = 10)
        {
            if (tryCount <= 0)
                return null;

            Image source, compressed;
            //压缩图片
            try
            {
                source = Image.FromFile(imagePath);
                compressed = ResizeImage(source, source.Width / 10, source.Height / 10);
                source.Dispose();
            }
            catch
            {
                return GetImage(imagePath, tryCount - 1);
            }

            return compressed;
        }
        #endregion

        #region Action
        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTextPath) || !isAnalysised)
                return;

            SaveManager.Ins.data.analysisPath = TB_TargetPath.Text;
            SaveManager.Ins.SaveData();

            SetNewGroupToVSC(selectedTextPath);

            TimerManager.Ins.Start((int)(groupInterval * 60));
        }
        private void Btn_RandomList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTextPath) || !isAnalysised)
                return;

            List<string> paths = BGAnalysis.Ins.GetPaths(selectedTextPath);
            RandomPathList(ref paths);

            BGAnalysis.Ins.WriteTxt(selectedTextPath, PathListToString(paths));

            UpdatePreview();
        }
        private void CB_IsAutoRandom_CheckedChanged(object sender, EventArgs e)
        {
            isAutoRandom = CB_IsAutoRandom.Checked;

            SaveManager.Ins.data.isAutoRandom = isAutoRandom;
            SaveManager.Ins.SaveData();
        }
        private void CB_IsSlideShow_CheckedChanged(object sender, EventArgs e)
        {
            isSlideShow = CB_IsSlideShow.Checked;

            if (isSlideShow && isAnalysised)
                TimerManager.Ins.Start((int)(groupInterval * 60));
            else
                TimerManager.Ins.Stop();

            SaveManager.Ins.data.isSlideShow = isSlideShow;
            SaveManager.Ins.SaveData();
        }
        private void TB_SingleInterval_TextChanged(object sender, EventArgs e)
        {
            singleInterval = (int)(float.Parse(TB_SingleInterval.Text) * 60);

            SaveManager.Ins.data.singleInterval = singleInterval;
            SaveManager.Ins.SaveData();

            VSCSettings.Ins.SetSingleInterval(singleInterval);
        }
        private void TB_GroupInterval_TextChanged(object sender, EventArgs e)
        {
            groupInterval = float.Parse(TB_GroupInterval.Text);

            SaveManager.Ins.data.groupInterval = groupInterval;
            SaveManager.Ins.SaveData();

            if (isAnalysised)
                TimerManager.Ins.Start((int)(groupInterval * 60));
        }
        private void CB_AlignType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isAnalysised)
                return;

            string cssCode = "";
            switch(CB_AlignType.SelectedIndex)
            {
            case 0:
                cssCode = "center";
                break;
            case 1:
                cssCode = "90%";
                break;
            case 2:
                cssCode = "left";
                break;
            case 3:
                cssCode = "upper";
                break;
            case 4:
                cssCode = "bottom";
                break;
            case 5:
                cssCode = "left upper";
                break;
            case 6:
                cssCode = "left bottom";
                break;
            case 7:
                cssCode = "90% upper";
                break;
            case 8:
                cssCode = "90% bottom";
                break;
            }

            aliginType = CB_AlignType.SelectedIndex;
            SaveManager.Ins.data.AlignType = CB_AlignType.SelectedIndex;
            SaveManager.Ins.SaveData();

            VSCSettings.Ins.SetBackgroundAlignStyle(cssCode);
        }
        private void CB_RepeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isAnalysised)
                return;

            string cssCode = "";
            switch (CB_RepeatType.SelectedIndex)
            {
            case 0:
                cssCode = "no-repeat";
                break;
            case 1:
                cssCode = "repeat-x";
                break;
            case 2:
                cssCode = "repeat-y";
                break;
            case 3:
                cssCode = "repeat";
                break;
            }

            repeatType = CB_RepeatType.SelectedIndex;
            SaveManager.Ins.data.RpeatType = CB_RepeatType.SelectedIndex;
            SaveManager.Ins.SaveData();

            VSCSettings.Ins.SetbackgroundRepeatType(cssCode);
        }
        private void TB_Opacity_TextChanged(object sender, EventArgs e)
        {
            opacityPercent = int.Parse(TB_Opacity.Text);
            SaveManager.Ins.data.OpacityPercent = opacityPercent;
            SaveManager.Ins.SaveData();

            VSCSettings.Ins.SetBackgroundOpacity(opacityPercent);
        }
        #endregion

        #region Timer
        private void OnTick(int remainTime)
        {
            TB_RemainGroupTimes.Text = remainTime.ToString();
        }
        private void OnTimerCompleted()
        {
            //从Manifest中选一个新的壁纸
            string manifestPath = SaveManager.Ins.GetManifestPath();
            List<string> txtPaths = BGAnalysis.Ins.GetPaths(manifestPath);

            int curIndex = -1;
            string fullPath = displayPathToRealPath(usedTextPath);
            for (int i = 0; i <  txtPaths.Count; i++)
            {
                if (txtPaths[i] == fullPath)
                {
                    curIndex = i;
                    break;
                }
            }
            if (curIndex == -1)
                return;

            //下一个壁纸组的文件位置
            string nextTxtPath = txtPaths[(curIndex + 1) % txtPaths.Count];
            List<string> imgPaths = BGAnalysis.Ins.GetPaths(nextTxtPath);

            //如果需要打乱，则将其进行打乱并写回txt文件
            if (isAutoRandom)
            {
                RandomPathList(ref imgPaths);
                BGAnalysis.Ins.WriteTxt(nextTxtPath, PathListToString(imgPaths));
            }

            //切换新的Group（应用到VSCode的settings.json）
            SetNewGroupToVSC(nextTxtPath);

            //重置定时器
            if (SaveManager.Ins.data.isAnalysised)
                TimerManager.Ins.Start((int)(groupInterval * 60));
        }
        #endregion

        #region Utility
        void SetNewGroupToVSC(string textPath)
        {
            List<string> paths = BGAnalysis.Ins.GetPaths(textPath);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            for (int i = 0; i <  paths.Count; i++)
            {
                stringBuilder.AppendLine("\"" + "file:///" + paths[i] + "\",");
            }
            stringBuilder.Append("]");

            VSCSettings.Ins.SetBackgroundList(stringBuilder.ToString());

            //SaveData
            //参数
            SaveManager.Ins.data.singleInterval = singleInterval;
            SaveManager.Ins.data.groupInterval = groupInterval;
            SaveManager.Ins.data.isAutoRandom = isAutoRandom;
            SaveManager.Ins.data.isSlideShow = isSlideShow;
            //路径
            TB_CurUsedGroup.Text = realPathToDisplayPath(textPath);
            usedTextPath = TB_CurUsedGroup.Text;
            SaveManager.Ins.data.usedPath = usedTextPath;
            SaveManager.Ins.SaveData();
        }

        private void RandomPathList(ref List<string> list)
        {
            int count = list.Count;
            Random rand = new Random(System.DateTime.Now.Millisecond);

            for (int i = 0; i < count; i++)
            {
                int cur = rand.Next(0, count - i);

                string tmp = list[cur];
                list[cur] = list[count - i - 1];
                list[count - i - 1] = tmp;
            }
        }

        private string PathListToString(List<string> paths)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(paths.Count.ToString());
            foreach (var path in paths)
            {
                stringBuilder.AppendLine(path);
            }
            return stringBuilder.ToString();
        }
        private string GetManifestPath()
        {
            if (string.IsNullOrEmpty(TB_TargetPath.Text))
                return null;
            return TB_TargetPath.Text.Replace("\\", "/") + "/" + Path.GetFileName(TB_TargetPath.Text) + ".txt";
        }
        private string displayPathToRealPath(string displayPath)
        {
            return Path.GetDirectoryName(TB_TargetPath.Text).Replace("\\", "/") + "/" + displayPath + ".txt";
        }
        private string realPathToDisplayPath(string realPath)
        {
            int startIndex = TB_TargetPath.Text.Length - Path.GetFileName(TB_TargetPath.Text).Length;
            return realPath.Substring(startIndex, realPath.LastIndexOf('.') - startIndex);
        }
        #endregion

        #region Form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing &&
        MessageBox.Show("你确定要退出程序吗？（设置在输入时即保存）", "关闭提示",
            System.Windows.Forms.MessageBoxButtons.YesNo,
            System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                notifyIcon1.Visible = false;   //设置图标不可见
                e.Cancel = false;              // 允许窗体关闭
            }
            else
            {
                e.Cancel = true;               // 取消窗体关闭
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void showWindow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;   //设置图标不可见
            this.Close();                  //关闭窗体
            this.Dispose();                //释放资源
            Application.Exit();            //关闭应用程序窗体
        }

        #endregion

        private void Btn_SwitchLanguage_Click(object sender, EventArgs e)
        {
            int currentLcid = System.Threading.Thread.CurrentThread.CurrentUICulture.LCID;
            currentLcid = (currentLcid == 2052) ? 1033 : 2052;//这里的2052是中文   1033是英文
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(currentLcid);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            foreach (Control ct in this.Controls)//循环当前界面所有的控件
            {
                if(ct.Name == "TB_TargetPath" || ct.Name == "TB_settingsPath")
                    continue;

                resources.ApplyResources(ct, ct.Name);
                if (ct.HasChildren)
                {
                    resources.ApplyResources(ct, ct.Name);
                }
            }

            useEnglish = !useEnglish;
            SaveManager.Ins.data.useEnglish = useEnglish;
            SaveManager.Ins.SaveData();
        }
        private void CB_UseFront_CheckedChanged(object sender, EventArgs e)
        {
            useFront = CB_UseFront.Checked;
            SaveManager.Ins.data.useFront = useFront;
            SaveManager.Ins.SaveData();

            VSCSettings.Ins.SetUseFront(useFront);
        }
    }
}
