namespace VSC_BackgroundSetting
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BGAnalysisBtn = new System.Windows.Forms.Button();
            this.Btn_SelectTargetPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_TargetPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_MaxBGgroupNum = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.BGgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_SelectSettingsPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_settingsPath = new System.Windows.Forms.TextBox();
            this.Btn_ClearTxt = new System.Windows.Forms.Button();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.TB_CurUsedGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CurSelectedGroup = new System.Windows.Forms.TextBox();
            this.Btn_RandomList = new System.Windows.Forms.Button();
            this.imgPreview = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.TB_previewImgNum = new System.Windows.Forms.TextBox();
            this.CB_IsSlideShow = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_GroupInterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_IsAutoRandom = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_SingleInterval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SlideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.TB_RemainGroupTimes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CB_AlignType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CB_RepeatType = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_SwitchLanguage = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_Opacity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CB_UseFront = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGAnalysisBtn
            // 
            resources.ApplyResources(this.BGAnalysisBtn, "BGAnalysisBtn");
            this.BGAnalysisBtn.Name = "BGAnalysisBtn";
            this.BGAnalysisBtn.UseVisualStyleBackColor = true;
            this.BGAnalysisBtn.Click += new System.EventHandler(this.Btn_Analysis_Click);
            // 
            // Btn_SelectTargetPath
            // 
            this.Btn_SelectTargetPath.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Btn_SelectTargetPath, "Btn_SelectTargetPath");
            this.Btn_SelectTargetPath.Name = "Btn_SelectTargetPath";
            this.Btn_SelectTargetPath.UseVisualStyleBackColor = true;
            this.Btn_SelectTargetPath.Click += new System.EventHandler(this.Btn_SelectTargetPath_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TB_TargetPath
            // 
            resources.ApplyResources(this.TB_TargetPath, "TB_TargetPath");
            this.TB_TargetPath.Name = "TB_TargetPath";
            this.TB_TargetPath.TextChanged += new System.EventHandler(this.TB_TargetPath_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TB_MaxBGgroupNum
            // 
            resources.ApplyResources(this.TB_MaxBGgroupNum, "TB_MaxBGgroupNum");
            this.TB_MaxBGgroupNum.Name = "TB_MaxBGgroupNum";
            this.TB_MaxBGgroupNum.TextChanged += new System.EventHandler(this.TB_MaxBGgroupNum_TextChanged);
            // 
            // dataGrid
            // 
            resources.ApplyResources(this.dataGrid, "dataGrid");
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BGgroup,
            this.BGnum});
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            // 
            // BGgroup
            // 
            resources.ApplyResources(this.BGgroup, "BGgroup");
            this.BGgroup.Name = "BGgroup";
            // 
            // BGnum
            // 
            resources.ApplyResources(this.BGnum, "BGnum");
            this.BGnum.Name = "BGnum";
            // 
            // Btn_SelectSettingsPath
            // 
            resources.ApplyResources(this.Btn_SelectSettingsPath, "Btn_SelectSettingsPath");
            this.Btn_SelectSettingsPath.ForeColor = System.Drawing.Color.Black;
            this.Btn_SelectSettingsPath.Name = "Btn_SelectSettingsPath";
            this.Btn_SelectSettingsPath.UseVisualStyleBackColor = true;
            this.Btn_SelectSettingsPath.Click += new System.EventHandler(this.Btn_SelectSettingsPath_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TB_settingsPath
            // 
            resources.ApplyResources(this.TB_settingsPath, "TB_settingsPath");
            this.TB_settingsPath.Name = "TB_settingsPath";
            this.TB_settingsPath.TextChanged += new System.EventHandler(this.TB_settingsPath_TextChanged);
            // 
            // Btn_ClearTxt
            // 
            resources.ApplyResources(this.Btn_ClearTxt, "Btn_ClearTxt");
            this.Btn_ClearTxt.Name = "Btn_ClearTxt";
            this.Btn_ClearTxt.UseVisualStyleBackColor = true;
            this.Btn_ClearTxt.Click += new System.EventHandler(this.Btn_ClearTxt_Click);
            // 
            // Btn_Apply
            // 
            resources.ApplyResources(this.Btn_Apply, "Btn_Apply");
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // TB_CurUsedGroup
            // 
            resources.ApplyResources(this.TB_CurUsedGroup, "TB_CurUsedGroup");
            this.TB_CurUsedGroup.Name = "TB_CurUsedGroup";
            this.TB_CurUsedGroup.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TB_CurSelectedGroup
            // 
            resources.ApplyResources(this.TB_CurSelectedGroup, "TB_CurSelectedGroup");
            this.TB_CurSelectedGroup.Name = "TB_CurSelectedGroup";
            this.TB_CurSelectedGroup.ReadOnly = true;
            // 
            // Btn_RandomList
            // 
            resources.ApplyResources(this.Btn_RandomList, "Btn_RandomList");
            this.Btn_RandomList.Name = "Btn_RandomList";
            this.Btn_RandomList.UseVisualStyleBackColor = true;
            this.Btn_RandomList.Click += new System.EventHandler(this.Btn_RandomList_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.imgPreview, "imgPreview");
            this.imgPreview.BackgroundImageTiled = true;
            this.imgPreview.HideSelection = false;
            this.imgPreview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("imgPreview.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("imgPreview.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("imgPreview.Items2"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("imgPreview.Items3")))});
            this.imgPreview.LargeImageList = this.imgList;
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.SmallImageList = this.imgList;
            this.imgPreview.TileSize = new System.Drawing.Size(130, 144);
            this.imgPreview.UseCompatibleStateImageBehavior = false;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imgList, "imgList");
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TB_previewImgNum
            // 
            resources.ApplyResources(this.TB_previewImgNum, "TB_previewImgNum");
            this.TB_previewImgNum.Name = "TB_previewImgNum";
            this.TB_previewImgNum.TextChanged += new System.EventHandler(this.TB_previewImgNum_TextChanged);
            // 
            // CB_IsSlideShow
            // 
            resources.ApplyResources(this.CB_IsSlideShow, "CB_IsSlideShow");
            this.CB_IsSlideShow.Name = "CB_IsSlideShow";
            this.CB_IsSlideShow.UseVisualStyleBackColor = true;
            this.CB_IsSlideShow.CheckedChanged += new System.EventHandler(this.CB_IsSlideShow_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // TB_GroupInterval
            // 
            resources.ApplyResources(this.TB_GroupInterval, "TB_GroupInterval");
            this.TB_GroupInterval.Name = "TB_GroupInterval";
            this.TB_GroupInterval.TextChanged += new System.EventHandler(this.TB_GroupInterval_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // CB_IsAutoRandom
            // 
            resources.ApplyResources(this.CB_IsAutoRandom, "CB_IsAutoRandom");
            this.CB_IsAutoRandom.Name = "CB_IsAutoRandom";
            this.CB_IsAutoRandom.UseVisualStyleBackColor = true;
            this.CB_IsAutoRandom.CheckedChanged += new System.EventHandler(this.CB_IsAutoRandom_CheckedChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // TB_SingleInterval
            // 
            resources.ApplyResources(this.TB_SingleInterval, "TB_SingleInterval");
            this.TB_SingleInterval.Name = "TB_SingleInterval";
            this.TB_SingleInterval.TextChanged += new System.EventHandler(this.TB_SingleInterval_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Interval = 1000;
            // 
            // TB_RemainGroupTimes
            // 
            resources.ApplyResources(this.TB_RemainGroupTimes, "TB_RemainGroupTimes");
            this.TB_RemainGroupTimes.Name = "TB_RemainGroupTimes";
            this.TB_RemainGroupTimes.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // CB_AlignType
            // 
            resources.ApplyResources(this.CB_AlignType, "CB_AlignType");
            this.CB_AlignType.FormattingEnabled = true;
            this.CB_AlignType.Items.AddRange(new object[] {
            resources.GetString("CB_AlignType.Items"),
            resources.GetString("CB_AlignType.Items1"),
            resources.GetString("CB_AlignType.Items2"),
            resources.GetString("CB_AlignType.Items3"),
            resources.GetString("CB_AlignType.Items4"),
            resources.GetString("CB_AlignType.Items5"),
            resources.GetString("CB_AlignType.Items6"),
            resources.GetString("CB_AlignType.Items7"),
            resources.GetString("CB_AlignType.Items8")});
            this.CB_AlignType.Name = "CB_AlignType";
            this.CB_AlignType.SelectedIndexChanged += new System.EventHandler(this.CB_AlignType_SelectedIndexChanged);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // CB_RepeatType
            // 
            resources.ApplyResources(this.CB_RepeatType, "CB_RepeatType");
            this.CB_RepeatType.FormattingEnabled = true;
            this.CB_RepeatType.Items.AddRange(new object[] {
            resources.GetString("CB_RepeatType.Items"),
            resources.GetString("CB_RepeatType.Items1"),
            resources.GetString("CB_RepeatType.Items2"),
            resources.GetString("CB_RepeatType.Items3")});
            this.CB_RepeatType.Name = "CB_RepeatType";
            this.CB_RepeatType.SelectedIndexChanged += new System.EventHandler(this.CB_RepeatType_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindow,
            this.toolStripSeparator1,
            this.quit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // showWindow
            // 
            this.showWindow.Name = "showWindow";
            resources.ApplyResources(this.showWindow, "showWindow");
            this.showWindow.Click += new System.EventHandler(this.showWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // quit
            // 
            this.quit.Name = "quit";
            resources.ApplyResources(this.quit, "quit");
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Btn_SwitchLanguage
            // 
            resources.ApplyResources(this.Btn_SwitchLanguage, "Btn_SwitchLanguage");
            this.Btn_SwitchLanguage.Name = "Btn_SwitchLanguage";
            this.Btn_SwitchLanguage.UseVisualStyleBackColor = true;
            this.Btn_SwitchLanguage.Click += new System.EventHandler(this.Btn_SwitchLanguage_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // TB_Opacity
            // 
            resources.ApplyResources(this.TB_Opacity, "TB_Opacity");
            this.TB_Opacity.Name = "TB_Opacity";
            this.TB_Opacity.TextChanged += new System.EventHandler(this.TB_Opacity_TextChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // CB_UseFront
            // 
            resources.ApplyResources(this.CB_UseFront, "CB_UseFront");
            this.CB_UseFront.Name = "CB_UseFront";
            this.CB_UseFront.UseVisualStyleBackColor = true;
            this.CB_UseFront.CheckedChanged += new System.EventHandler(this.CB_UseFront_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_UseFront);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TB_Opacity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Btn_SwitchLanguage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CB_RepeatType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CB_AlignType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_RemainGroupTimes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_SingleInterval);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CB_IsAutoRandom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_GroupInterval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_IsSlideShow);
            this.Controls.Add(this.TB_previewImgNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.Btn_RandomList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_CurSelectedGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_CurUsedGroup);
            this.Controls.Add(this.Btn_Apply);
            this.Controls.Add(this.Btn_ClearTxt);
            this.Controls.Add(this.Btn_SelectSettingsPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_settingsPath);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.TB_MaxBGgroupNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_SelectTargetPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_TargetPath);
            this.Controls.Add(this.BGAnalysisBtn);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGAnalysisBtn;
        private System.Windows.Forms.Button Btn_SelectTargetPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_TargetPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_MaxBGgroupNum;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button Btn_SelectSettingsPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_settingsPath;
        private System.Windows.Forms.Button Btn_ClearTxt;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.TextBox TB_CurUsedGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CurSelectedGroup;
        private System.Windows.Forms.Button Btn_RandomList;
        private System.Windows.Forms.ListView imgPreview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_previewImgNum;
        protected internal System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.CheckBox CB_IsSlideShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_GroupInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CB_IsAutoRandom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_SingleInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer SlideShowTimer;
        private System.Windows.Forms.TextBox TB_RemainGroupTimes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CB_RepeatType;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGnum;
        private System.Windows.Forms.Button Btn_SwitchLanguage;
        private System.Windows.Forms.ComboBox CB_AlignType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_Opacity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CB_UseFront;
    }
}

