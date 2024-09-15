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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 7);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 10);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGAnalysisBtn
            // 
            this.BGAnalysisBtn.Location = new System.Drawing.Point(341, 79);
            this.BGAnalysisBtn.Name = "BGAnalysisBtn";
            this.BGAnalysisBtn.Size = new System.Drawing.Size(100, 42);
            this.BGAnalysisBtn.TabIndex = 0;
            this.BGAnalysisBtn.Text = "解析壁纸文件夹";
            this.BGAnalysisBtn.UseVisualStyleBackColor = true;
            this.BGAnalysisBtn.Click += new System.EventHandler(this.Btn_Analysis_Click);
            // 
            // Btn_SelectTargetPath
            // 
            this.Btn_SelectTargetPath.ForeColor = System.Drawing.Color.Black;
            this.Btn_SelectTargetPath.Location = new System.Drawing.Point(409, 43);
            this.Btn_SelectTargetPath.Name = "Btn_SelectTargetPath";
            this.Btn_SelectTargetPath.Size = new System.Drawing.Size(32, 24);
            this.Btn_SelectTargetPath.TabIndex = 5;
            this.Btn_SelectTargetPath.Text = "...";
            this.Btn_SelectTargetPath.UseVisualStyleBackColor = true;
            this.Btn_SelectTargetPath.Click += new System.EventHandler(this.Btn_SelectTargetPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "解析壁纸根目录";
            // 
            // TB_TargetPath
            // 
            this.TB_TargetPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_TargetPath.Location = new System.Drawing.Point(12, 44);
            this.TB_TargetPath.Name = "TB_TargetPath";
            this.TB_TargetPath.Size = new System.Drawing.Size(391, 23);
            this.TB_TargetPath.TabIndex = 3;
            this.TB_TargetPath.Text = "E:\\媒体\\秘密\\18";
            this.TB_TargetPath.TextChanged += new System.EventHandler(this.TB_TargetPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "壁纸组大小";
            // 
            // TB_MaxBGgroupNum
            // 
            this.TB_MaxBGgroupNum.Location = new System.Drawing.Point(12, 100);
            this.TB_MaxBGgroupNum.Name = "TB_MaxBGgroupNum";
            this.TB_MaxBGgroupNum.Size = new System.Drawing.Size(63, 21);
            this.TB_MaxBGgroupNum.TabIndex = 7;
            this.TB_MaxBGgroupNum.Text = "100";
            this.TB_MaxBGgroupNum.TextChanged += new System.EventHandler(this.TB_MaxBGgroupNum_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BGgroup,
            this.BGnum});
            this.dataGrid.Location = new System.Drawing.Point(12, 139);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(429, 441);
            this.dataGrid.TabIndex = 8;
            // 
            // BGgroup
            // 
            this.BGgroup.HeaderText = "壁纸组";
            this.BGgroup.Name = "BGgroup";
            this.BGgroup.Width = 300;
            // 
            // BGnum
            // 
            this.BGnum.HeaderText = "壁纸数量";
            this.BGnum.Name = "BGnum";
            // 
            // Btn_SelectSettingsPath
            // 
            this.Btn_SelectSettingsPath.ForeColor = System.Drawing.Color.Black;
            this.Btn_SelectSettingsPath.Location = new System.Drawing.Point(849, 42);
            this.Btn_SelectSettingsPath.Name = "Btn_SelectSettingsPath";
            this.Btn_SelectSettingsPath.Size = new System.Drawing.Size(32, 24);
            this.Btn_SelectSettingsPath.TabIndex = 11;
            this.Btn_SelectSettingsPath.Text = "...";
            this.Btn_SelectSettingsPath.UseVisualStyleBackColor = true;
            this.Btn_SelectSettingsPath.Click += new System.EventHandler(this.Btn_SelectSettingsPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "VSCode settings.json 路径";
            // 
            // TB_settingsPath
            // 
            this.TB_settingsPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_settingsPath.Location = new System.Drawing.Point(464, 43);
            this.TB_settingsPath.Name = "TB_settingsPath";
            this.TB_settingsPath.Size = new System.Drawing.Size(375, 23);
            this.TB_settingsPath.TabIndex = 9;
            this.TB_settingsPath.Text = "C:\\Users\\Administrator\\AppData\\Roaming\\Code\\User\\settings.json";
            this.TB_settingsPath.TextChanged += new System.EventHandler(this.TB_settingsPath_TextChanged);
            // 
            // Btn_ClearTxt
            // 
            this.Btn_ClearTxt.Location = new System.Drawing.Point(225, 79);
            this.Btn_ClearTxt.Name = "Btn_ClearTxt";
            this.Btn_ClearTxt.Size = new System.Drawing.Size(100, 42);
            this.Btn_ClearTxt.TabIndex = 12;
            this.Btn_ClearTxt.Text = "清空解析文件";
            this.Btn_ClearTxt.UseVisualStyleBackColor = true;
            this.Btn_ClearTxt.Click += new System.EventHandler(this.Btn_ClearTxt_Click);
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Location = new System.Drawing.Point(768, 137);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(113, 42);
            this.Btn_Apply.TabIndex = 13;
            this.Btn_Apply.Text = "替换为当前壁纸组";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // TB_CurUsedGroup
            // 
            this.TB_CurUsedGroup.Location = new System.Drawing.Point(464, 100);
            this.TB_CurUsedGroup.Name = "TB_CurUsedGroup";
            this.TB_CurUsedGroup.ReadOnly = true;
            this.TB_CurUsedGroup.Size = new System.Drawing.Size(187, 21);
            this.TB_CurUsedGroup.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "当前壁纸组";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "当前选择的壁纸组";
            // 
            // TB_CurSelectedGroup
            // 
            this.TB_CurSelectedGroup.Location = new System.Drawing.Point(464, 160);
            this.TB_CurSelectedGroup.Name = "TB_CurSelectedGroup";
            this.TB_CurSelectedGroup.ReadOnly = true;
            this.TB_CurSelectedGroup.Size = new System.Drawing.Size(187, 21);
            this.TB_CurSelectedGroup.TabIndex = 16;
            // 
            // Btn_RandomList
            // 
            this.Btn_RandomList.Location = new System.Drawing.Point(768, 77);
            this.Btn_RandomList.Name = "Btn_RandomList";
            this.Btn_RandomList.Size = new System.Drawing.Size(113, 42);
            this.Btn_RandomList.TabIndex = 18;
            this.Btn_RandomList.Text = "随机顺序";
            this.Btn_RandomList.UseVisualStyleBackColor = true;
            this.Btn_RandomList.Click += new System.EventHandler(this.Btn_RandomList_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imgPreview.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.imgPreview.BackgroundImageTiled = true;
            this.imgPreview.HideSelection = false;
            this.imgPreview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.imgPreview.LargeImageList = this.imgList;
            this.imgPreview.Location = new System.Drawing.Point(466, 229);
            this.imgPreview.Margin = new System.Windows.Forms.Padding(0);
            this.imgPreview.MinimumSize = new System.Drawing.Size(10, 10);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(415, 351);
            this.imgPreview.SmallImageList = this.imgList;
            this.imgPreview.TabIndex = 19;
            this.imgPreview.TileSize = new System.Drawing.Size(130, 144);
            this.imgPreview.UseCompatibleStateImageBehavior = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "00cdbaa7-bdac-41ae-9a10-61c334e04cef.jpg");
            this.imgList.Images.SetKeyName(1, "0b0766a8-7be0-488a-b7db-a48ad95f3e4b.jpg");
            this.imgList.Images.SetKeyName(2, "01ffdab4-e72c-4ce0-a704-722774565975.jpg");
            this.imgList.Images.SetKeyName(3, "1ab13237-8d6e-4be6-90a1-76f80f419204.jpg");
            this.imgList.Images.SetKeyName(4, "1c2b0b67-5d38-47ed-b3ec-6b99bd9d5e53.jpg");
            this.imgList.Images.SetKeyName(5, "1fe43827-1c4b-4238-aacb-f307a1be15c7.jpg");
            this.imgList.Images.SetKeyName(6, "03c81e72-d0e6-4b7a-bc94-21003e00dac5.jpg");
            this.imgList.Images.SetKeyName(7, "7ce5cf69-65f3-4464-9d36-f2944b63ca19.jpg");
            this.imgList.Images.SetKeyName(8, "7e36cd5c-53cb-4c5f-a384-5a9a82ab7977.jpg");
            this.imgList.Images.SetKeyName(9, "8b096818-34e3-42be-bc41-3763b873192d.jpg");
            this.imgList.Images.SetKeyName(10, "8d2e8848-f041-4546-a825-5ac7514a3433.jpg");
            this.imgList.Images.SetKeyName(11, "9a05bb91-0810-43fd-a715-681af6f5920d.jpg");
            this.imgList.Images.SetKeyName(12, "9cb45919-aa03-4a7a-8fba-f6c674b27b65.jpg");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "预览数量";
            // 
            // TB_previewImgNum
            // 
            this.TB_previewImgNum.Location = new System.Drawing.Point(523, 199);
            this.TB_previewImgNum.Name = "TB_previewImgNum";
            this.TB_previewImgNum.Size = new System.Drawing.Size(28, 21);
            this.TB_previewImgNum.TabIndex = 21;
            this.TB_previewImgNum.Text = "10";
            this.TB_previewImgNum.TextChanged += new System.EventHandler(this.TB_previewImgNum_TextChanged);
            // 
            // CB_IsSlideShow
            // 
            this.CB_IsSlideShow.AutoSize = true;
            this.CB_IsSlideShow.Location = new System.Drawing.Point(665, 97);
            this.CB_IsSlideShow.Name = "CB_IsSlideShow";
            this.CB_IsSlideShow.Size = new System.Drawing.Size(72, 16);
            this.CB_IsSlideShow.TabIndex = 22;
            this.CB_IsSlideShow.Text = "是否轮播";
            this.CB_IsSlideShow.UseVisualStyleBackColor = true;
            this.CB_IsSlideShow.CheckedChanged += new System.EventHandler(this.CB_IsSlideShow_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "轮播间隔";
            // 
            // TB_GroupInterval
            // 
            this.TB_GroupInterval.Location = new System.Drawing.Point(825, 200);
            this.TB_GroupInterval.Name = "TB_GroupInterval";
            this.TB_GroupInterval.Size = new System.Drawing.Size(27, 21);
            this.TB_GroupInterval.TabIndex = 24;
            this.TB_GroupInterval.Text = "999";
            this.TB_GroupInterval.TextChanged += new System.EventHandler(this.TB_GroupInterval_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "min";
            // 
            // CB_IsAutoRandom
            // 
            this.CB_IsAutoRandom.AutoSize = true;
            this.CB_IsAutoRandom.Location = new System.Drawing.Point(665, 72);
            this.CB_IsAutoRandom.Name = "CB_IsAutoRandom";
            this.CB_IsAutoRandom.Size = new System.Drawing.Size(72, 16);
            this.CB_IsAutoRandom.TabIndex = 28;
            this.CB_IsAutoRandom.Text = "自动随机";
            this.CB_IsAutoRandom.UseVisualStyleBackColor = true;
            this.CB_IsAutoRandom.CheckedChanged += new System.EventHandler(this.CB_IsAutoRandom_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(699, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "min";
            // 
            // TB_SingleInterval
            // 
            this.TB_SingleInterval.Location = new System.Drawing.Point(665, 199);
            this.TB_SingleInterval.Name = "TB_SingleInterval";
            this.TB_SingleInterval.Size = new System.Drawing.Size(28, 21);
            this.TB_SingleInterval.TabIndex = 30;
            this.TB_SingleInterval.Text = "5";
            this.TB_SingleInterval.TextChanged += new System.EventHandler(this.TB_SingleInterval_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "单张间隔";
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Interval = 1000;
            // 
            // TB_RemainGroupTimes
            // 
            this.TB_RemainGroupTimes.Location = new System.Drawing.Point(695, 169);
            this.TB_RemainGroupTimes.Name = "TB_RemainGroupTimes";
            this.TB_RemainGroupTimes.ReadOnly = true;
            this.TB_RemainGroupTimes.Size = new System.Drawing.Size(62, 21);
            this.TB_RemainGroupTimes.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(663, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "余时";
            // 
            // CB_AlignType
            // 
            this.CB_AlignType.FormattingEnabled = true;
            this.CB_AlignType.Items.AddRange(new object[] {
            "居中",
            "右",
            "左",
            "上",
            "下",
            "左上",
            "左下",
            "右上",
            "右下"});
            this.CB_AlignType.Location = new System.Drawing.Point(695, 118);
            this.CB_AlignType.Name = "CB_AlignType";
            this.CB_AlignType.Size = new System.Drawing.Size(62, 20);
            this.CB_AlignType.TabIndex = 34;
            this.CB_AlignType.Text = "右";
            this.CB_AlignType.SelectedIndexChanged += new System.EventHandler(this.CB_AlignType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(663, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "对齐";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(663, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "重复";
            // 
            // CB_RepeatType
            // 
            this.CB_RepeatType.FormattingEnabled = true;
            this.CB_RepeatType.Items.AddRange(new object[] {
            "无",
            "水平",
            "垂直",
            "全铺"});
            this.CB_RepeatType.Location = new System.Drawing.Point(695, 143);
            this.CB_RepeatType.Name = "CB_RepeatType";
            this.CB_RepeatType.Size = new System.Drawing.Size(62, 20);
            this.CB_RepeatType.TabIndex = 36;
            this.CB_RepeatType.Text = "无";
            this.CB_RepeatType.SelectedIndexChanged += new System.EventHandler(this.CB_RepeatType_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindow,
            this.toolStripSeparator1,
            this.quit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 54);
            // 
            // showWindow
            // 
            this.showWindow.Name = "showWindow";
            this.showWindow.Size = new System.Drawing.Size(180, 22);
            this.showWindow.Text = "显示窗口";
            this.showWindow.Click += new System.EventHandler(this.showWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(180, 22);
            this.quit.Text = "退出";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 591);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VSCode壁纸管理器";
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
        private System.Windows.Forms.ComboBox CB_AlignType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CB_RepeatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGnum;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quit;
    }
}

