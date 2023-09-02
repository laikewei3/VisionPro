namespace VisionPro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_RunBtn = new System.Windows.Forms.Button();
            this.m_OpenBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_HistogramTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.m_HistogramInput = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_comboBoxHisROI = new System.Windows.Forms.ComboBox();
            this.m_HistogramOutput = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_HisOutTable = new System.Windows.Forms.TableLayoutPanel();
            this.m_tbSample = new System.Windows.Forms.TextBox();
            this.m_tbVariance = new System.Windows.Forms.TextBox();
            this.m_tbSD = new System.Windows.Forms.TextBox();
            this.m_tbMean = new System.Windows.Forms.TextBox();
            this.m_tbMode = new System.Windows.Forms.TextBox();
            this.m_tbMedian = new System.Windows.Forms.TextBox();
            this.m_tbMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_tbMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_BlobTab = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.m_CaliperTab = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cogDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.m_HistogramTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.m_HistogramInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.m_HistogramOutput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.m_HisOutTable.SuspendLayout();
            this.m_BlobTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.m_CaliperTab.SuspendLayout();
            this.tabControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.m_RunBtn);
            this.flowLayoutPanel1.Controls.Add(this.m_OpenBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 25);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // m_RunBtn
            // 
            this.m_RunBtn.Location = new System.Drawing.Point(3, 3);
            this.m_RunBtn.Name = "m_RunBtn";
            this.m_RunBtn.Size = new System.Drawing.Size(75, 23);
            this.m_RunBtn.TabIndex = 0;
            this.m_RunBtn.Text = "Run";
            this.m_RunBtn.UseVisualStyleBackColor = true;
            this.m_RunBtn.Click += new System.EventHandler(this.m_RunBtn_Click);
            // 
            // m_OpenBtn
            // 
            this.m_OpenBtn.Location = new System.Drawing.Point(84, 3);
            this.m_OpenBtn.Name = "m_OpenBtn";
            this.m_OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.m_OpenBtn.TabIndex = 1;
            this.m_OpenBtn.Text = "Open";
            this.m_OpenBtn.UseVisualStyleBackColor = true;
            this.m_OpenBtn.Click += new System.EventHandler(this.m_OpenBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.m_HistogramTab);
            this.tabControl1.Controls.Add(this.m_BlobTab);
            this.tabControl1.Controls.Add(this.m_CaliperTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(291, 419);
            this.tabControl1.TabIndex = 2;
            // 
            // m_HistogramTab
            // 
            this.m_HistogramTab.Controls.Add(this.tabControl2);
            this.m_HistogramTab.Location = new System.Drawing.Point(4, 4);
            this.m_HistogramTab.Name = "m_HistogramTab";
            this.m_HistogramTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_HistogramTab.Size = new System.Drawing.Size(283, 393);
            this.m_HistogramTab.TabIndex = 0;
            this.m_HistogramTab.Text = "Histogram";
            this.m_HistogramTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.m_HistogramInput);
            this.tabControl2.Controls.Add(this.m_HistogramOutput);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(277, 387);
            this.tabControl2.TabIndex = 0;
            // 
            // m_HistogramInput
            // 
            this.m_HistogramInput.Controls.Add(this.groupBox1);
            this.m_HistogramInput.Location = new System.Drawing.Point(4, 22);
            this.m_HistogramInput.Name = "m_HistogramInput";
            this.m_HistogramInput.Padding = new System.Windows.Forms.Padding(3);
            this.m_HistogramInput.Size = new System.Drawing.Size(269, 361);
            this.m_HistogramInput.TabIndex = 0;
            this.m_HistogramInput.Text = "Input";
            this.m_HistogramInput.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.m_comboBoxHisROI);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region";
            // 
            // m_comboBoxHisROI
            // 
            this.m_comboBoxHisROI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_comboBoxHisROI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxHisROI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_comboBoxHisROI.ItemHeight = 13;
            this.m_comboBoxHisROI.Items.AddRange(new object[] {
            "<None - Use Entire Image>",
            "CogRectangle"});
            this.m_comboBoxHisROI.Location = new System.Drawing.Point(3, 16);
            this.m_comboBoxHisROI.Margin = new System.Windows.Forms.Padding(10);
            this.m_comboBoxHisROI.Name = "m_comboBoxHisROI";
            this.m_comboBoxHisROI.Size = new System.Drawing.Size(257, 21);
            this.m_comboBoxHisROI.TabIndex = 0;
            this.m_comboBoxHisROI.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxHisROI_SelectedIndexChanged);
            // 
            // m_HistogramOutput
            // 
            this.m_HistogramOutput.Controls.Add(this.groupBox2);
            this.m_HistogramOutput.Location = new System.Drawing.Point(4, 22);
            this.m_HistogramOutput.Name = "m_HistogramOutput";
            this.m_HistogramOutput.Padding = new System.Windows.Forms.Padding(3);
            this.m_HistogramOutput.Size = new System.Drawing.Size(269, 361);
            this.m_HistogramOutput.TabIndex = 1;
            this.m_HistogramOutput.Text = "Output";
            this.m_HistogramOutput.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_HisOutTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 355);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statictics";
            // 
            // m_HisOutTable
            // 
            this.m_HisOutTable.ColumnCount = 2;
            this.m_HisOutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.m_HisOutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.m_HisOutTable.Controls.Add(this.m_tbSample, 1, 7);
            this.m_HisOutTable.Controls.Add(this.m_tbVariance, 1, 6);
            this.m_HisOutTable.Controls.Add(this.m_tbSD, 1, 5);
            this.m_HisOutTable.Controls.Add(this.m_tbMean, 1, 4);
            this.m_HisOutTable.Controls.Add(this.m_tbMode, 1, 3);
            this.m_HisOutTable.Controls.Add(this.m_tbMedian, 1, 2);
            this.m_HisOutTable.Controls.Add(this.m_tbMax, 1, 1);
            this.m_HisOutTable.Controls.Add(this.label3, 0, 2);
            this.m_HisOutTable.Controls.Add(this.label4, 0, 3);
            this.m_HisOutTable.Controls.Add(this.label5, 0, 4);
            this.m_HisOutTable.Controls.Add(this.label6, 0, 5);
            this.m_HisOutTable.Controls.Add(this.label1, 0, 0);
            this.m_HisOutTable.Controls.Add(this.label2, 0, 1);
            this.m_HisOutTable.Controls.Add(this.label7, 0, 6);
            this.m_HisOutTable.Controls.Add(this.m_tbMin, 1, 0);
            this.m_HisOutTable.Controls.Add(this.label8, 0, 7);
            this.m_HisOutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_HisOutTable.Location = new System.Drawing.Point(3, 16);
            this.m_HisOutTable.Name = "m_HisOutTable";
            this.m_HisOutTable.RowCount = 9;
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.m_HisOutTable.Size = new System.Drawing.Size(257, 336);
            this.m_HisOutTable.TabIndex = 0;
            // 
            // m_tbSample
            // 
            this.m_tbSample.Enabled = false;
            this.m_tbSample.Location = new System.Drawing.Point(80, 262);
            this.m_tbSample.Name = "m_tbSample";
            this.m_tbSample.Size = new System.Drawing.Size(100, 20);
            this.m_tbSample.TabIndex = 15;
            // 
            // m_tbVariance
            // 
            this.m_tbVariance.Enabled = false;
            this.m_tbVariance.Location = new System.Drawing.Point(80, 225);
            this.m_tbVariance.Name = "m_tbVariance";
            this.m_tbVariance.Size = new System.Drawing.Size(100, 20);
            this.m_tbVariance.TabIndex = 14;
            // 
            // m_tbSD
            // 
            this.m_tbSD.Enabled = false;
            this.m_tbSD.Location = new System.Drawing.Point(80, 188);
            this.m_tbSD.Name = "m_tbSD";
            this.m_tbSD.Size = new System.Drawing.Size(100, 20);
            this.m_tbSD.TabIndex = 13;
            // 
            // m_tbMean
            // 
            this.m_tbMean.Enabled = false;
            this.m_tbMean.Location = new System.Drawing.Point(80, 151);
            this.m_tbMean.Name = "m_tbMean";
            this.m_tbMean.Size = new System.Drawing.Size(100, 20);
            this.m_tbMean.TabIndex = 12;
            // 
            // m_tbMode
            // 
            this.m_tbMode.Enabled = false;
            this.m_tbMode.Location = new System.Drawing.Point(80, 114);
            this.m_tbMode.Name = "m_tbMode";
            this.m_tbMode.Size = new System.Drawing.Size(100, 20);
            this.m_tbMode.TabIndex = 11;
            // 
            // m_tbMedian
            // 
            this.m_tbMedian.Enabled = false;
            this.m_tbMedian.Location = new System.Drawing.Point(80, 77);
            this.m_tbMedian.Name = "m_tbMedian";
            this.m_tbMedian.Size = new System.Drawing.Size(100, 20);
            this.m_tbMedian.TabIndex = 10;
            // 
            // m_tbMax
            // 
            this.m_tbMax.Enabled = false;
            this.m_tbMax.Location = new System.Drawing.Point(80, 40);
            this.m_tbMax.Name = "m_tbMax";
            this.m_tbMax.Size = new System.Drawing.Size(100, 20);
            this.m_tbMax.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Median";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mean";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Std. Dev.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Variance";
            // 
            // m_tbMin
            // 
            this.m_tbMin.Enabled = false;
            this.m_tbMin.Location = new System.Drawing.Point(80, 3);
            this.m_tbMin.Name = "m_tbMin";
            this.m_tbMin.Size = new System.Drawing.Size(100, 20);
            this.m_tbMin.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.MaximumSize = new System.Drawing.Size(100, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Samples";
            // 
            // m_BlobTab
            // 
            this.m_BlobTab.Controls.Add(this.tabControl3);
            this.m_BlobTab.Location = new System.Drawing.Point(4, 4);
            this.m_BlobTab.Name = "m_BlobTab";
            this.m_BlobTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_BlobTab.Size = new System.Drawing.Size(283, 393);
            this.m_BlobTab.TabIndex = 1;
            this.m_BlobTab.Text = "Blob";
            this.m_BlobTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(277, 387);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(269, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(269, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // m_CaliperTab
            // 
            this.m_CaliperTab.Controls.Add(this.tabControl4);
            this.m_CaliperTab.Location = new System.Drawing.Point(4, 4);
            this.m_CaliperTab.Name = "m_CaliperTab";
            this.m_CaliperTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_CaliperTab.Size = new System.Drawing.Size(283, 393);
            this.m_CaliperTab.TabIndex = 2;
            this.m_CaliperTab.Text = "Caliper";
            this.m_CaliperTab.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage3);
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(3, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(277, 387);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(269, 361);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Input";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(269, 361);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Output";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(303, 0);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(497, 450);
            this.cogDisplay1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cogDisplay1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.m_HistogramTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.m_HistogramInput.ResumeLayout(false);
            this.m_HistogramInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.m_HistogramOutput.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.m_HisOutTable.ResumeLayout(false);
            this.m_HisOutTable.PerformLayout();
            this.m_BlobTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.m_CaliperTab.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button m_RunBtn;
        private System.Windows.Forms.Button m_OpenBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_HistogramTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage m_HistogramInput;
        private System.Windows.Forms.TabPage m_HistogramOutput;
        private System.Windows.Forms.TabPage m_BlobTab;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage m_CaliperTab;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Cognex.VisionPro.Display.CogDisplay cogDisplay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox m_comboBoxHisROI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel m_HisOutTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_tbMin;
        private System.Windows.Forms.TextBox m_tbSample;
        private System.Windows.Forms.TextBox m_tbVariance;
        private System.Windows.Forms.TextBox m_tbSD;
        private System.Windows.Forms.TextBox m_tbMean;
        private System.Windows.Forms.TextBox m_tbMode;
        private System.Windows.Forms.TextBox m_tbMedian;
        private System.Windows.Forms.TextBox m_tbMax;
    }
}

