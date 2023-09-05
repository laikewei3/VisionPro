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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_RunBtn = new System.Windows.Forms.Button();
            this.m_OpenBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_HistogramTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.m_HistogramInput = new System.Windows.Forms.TabPage();
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
            this.m_BlobInput = new System.Windows.Forms.TabPage();
            this.m_BlobOutput = new System.Windows.Forms.TabPage();
            this.m_CaliperTab = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.m_CaliperInput = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_gbEdgeMode = new System.Windows.Forms.GroupBox();
            this.m_CaliperOutput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.m_NumResult = new System.Windows.Forms.NumericUpDown();
            this.m_NumFilter = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.m_NumContrastThreshold = new System.Windows.Forms.NumericUpDown();
            this.m_radioPair = new System.Windows.Forms.RadioButton();
            this.m_radioSingle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.m_gbEdge1Polarity = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_NumEdgePairWidth = new System.Windows.Forms.NumericUpDown();
            this.m_DL0 = new System.Windows.Forms.RadioButton();
            this.m_LD0 = new System.Windows.Forms.RadioButton();
            this.m_Any0 = new System.Windows.Forms.RadioButton();
            this.m_DL1 = new System.Windows.Forms.RadioButton();
            this.m_LD1 = new System.Windows.Forms.RadioButton();
            this.m_Any1 = new System.Windows.Forms.RadioButton();
            this.m_CaliperRes = new System.Windows.Forms.DataGridView();
            this.cogDisplay1 = new Cognex.VisionPro.CogToolDisplay();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.m_HistogramTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.m_HistogramOutput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.m_HisOutTable.SuspendLayout();
            this.m_BlobTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.m_CaliperTab.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.m_CaliperInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.m_gbEdgeMode.SuspendLayout();
            this.m_CaliperOutput.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumContrastThreshold)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.m_gbEdge1Polarity.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumEdgePairWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_CaliperRes)).BeginInit();
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.m_HistogramInput.AutoScroll = true;
            this.m_HistogramInput.Location = new System.Drawing.Point(4, 22);
            this.m_HistogramInput.Name = "m_HistogramInput";
            this.m_HistogramInput.Padding = new System.Windows.Forms.Padding(3);
            this.m_HistogramInput.Size = new System.Drawing.Size(269, 361);
            this.m_HistogramInput.TabIndex = 0;
            this.m_HistogramInput.Text = "Input";
            this.m_HistogramInput.UseVisualStyleBackColor = true;
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
            this.tabControl3.Controls.Add(this.m_BlobInput);
            this.tabControl3.Controls.Add(this.m_BlobOutput);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(277, 387);
            this.tabControl3.TabIndex = 1;
            // 
            // m_BlobInput
            // 
            this.m_BlobInput.Location = new System.Drawing.Point(4, 22);
            this.m_BlobInput.Name = "m_BlobInput";
            this.m_BlobInput.Padding = new System.Windows.Forms.Padding(3);
            this.m_BlobInput.Size = new System.Drawing.Size(269, 361);
            this.m_BlobInput.TabIndex = 0;
            this.m_BlobInput.Text = "Input";
            this.m_BlobInput.UseVisualStyleBackColor = true;
            // 
            // m_BlobOutput
            // 
            this.m_BlobOutput.Location = new System.Drawing.Point(4, 22);
            this.m_BlobOutput.Name = "m_BlobOutput";
            this.m_BlobOutput.Padding = new System.Windows.Forms.Padding(3);
            this.m_BlobOutput.Size = new System.Drawing.Size(269, 361);
            this.m_BlobOutput.TabIndex = 1;
            this.m_BlobOutput.Text = "Output";
            this.m_BlobOutput.UseVisualStyleBackColor = true;
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
            this.tabControl4.Controls.Add(this.m_CaliperInput);
            this.tabControl4.Controls.Add(this.m_CaliperOutput);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(3, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(277, 387);
            this.tabControl4.TabIndex = 1;
            // 
            // m_CaliperInput
            // 
            this.m_CaliperInput.AutoScroll = true;
            this.m_CaliperInput.Controls.Add(this.panel1);
            this.m_CaliperInput.Location = new System.Drawing.Point(4, 22);
            this.m_CaliperInput.Name = "m_CaliperInput";
            this.m_CaliperInput.Padding = new System.Windows.Forms.Padding(3);
            this.m_CaliperInput.Size = new System.Drawing.Size(269, 361);
            this.m_CaliperInput.TabIndex = 0;
            this.m_CaliperInput.Text = "Input";
            this.m_CaliperInput.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.m_gbEdgeMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 290);
            this.panel1.TabIndex = 0;
            // 
            // m_gbEdgeMode
            // 
            this.m_gbEdgeMode.Controls.Add(this.tableLayoutPanel3);
            this.m_gbEdgeMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_gbEdgeMode.Location = new System.Drawing.Point(0, 0);
            this.m_gbEdgeMode.Name = "m_gbEdgeMode";
            this.m_gbEdgeMode.Size = new System.Drawing.Size(263, 187);
            this.m_gbEdgeMode.TabIndex = 0;
            this.m_gbEdgeMode.TabStop = false;
            this.m_gbEdgeMode.Text = "Edge Mode";
            // 
            // m_CaliperOutput
            // 
            this.m_CaliperOutput.Controls.Add(this.m_CaliperRes);
            this.m_CaliperOutput.Location = new System.Drawing.Point(4, 22);
            this.m_CaliperOutput.Name = "m_CaliperOutput";
            this.m_CaliperOutput.Padding = new System.Windows.Forms.Padding(3);
            this.m_CaliperOutput.Size = new System.Drawing.Size(269, 361);
            this.m_CaliperOutput.TabIndex = 1;
            this.m_CaliperOutput.Text = "Output";
            this.m_CaliperOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.m_NumResult, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.m_NumFilter, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.m_NumContrastThreshold, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 187);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // m_NumResult
            // 
            this.m_NumResult.Location = new System.Drawing.Point(134, 69);
            this.m_NumResult.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.m_NumResult.Name = "m_NumResult";
            this.m_NumResult.Size = new System.Drawing.Size(120, 20);
            this.m_NumResult.TabIndex = 5;
            this.m_NumResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_NumResult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_NumFilter
            // 
            this.m_NumFilter.Location = new System.Drawing.Point(134, 36);
            this.m_NumFilter.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.m_NumFilter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_NumFilter.Name = "m_NumFilter";
            this.m_NumFilter.Size = new System.Drawing.Size(120, 20);
            this.m_NumFilter.TabIndex = 4;
            this.m_NumFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_NumFilter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contrast Threshold";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Filter Half Size Pixels";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Maximum Results";
            // 
            // m_NumContrastThreshold
            // 
            this.m_NumContrastThreshold.DecimalPlaces = 1;
            this.m_NumContrastThreshold.Location = new System.Drawing.Point(134, 3);
            this.m_NumContrastThreshold.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.m_NumContrastThreshold.Name = "m_NumContrastThreshold";
            this.m_NumContrastThreshold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_NumContrastThreshold.Size = new System.Drawing.Size(120, 20);
            this.m_NumContrastThreshold.TabIndex = 3;
            this.m_NumContrastThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_NumContrastThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // m_radioPair
            // 
            this.m_radioPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_radioPair.AutoSize = true;
            this.m_radioPair.Location = new System.Drawing.Point(131, 3);
            this.m_radioPair.Name = "m_radioPair";
            this.m_radioPair.Size = new System.Drawing.Size(71, 24);
            this.m_radioPair.TabIndex = 1;
            this.m_radioPair.Text = "Edge Pair";
            this.m_radioPair.UseVisualStyleBackColor = true;
            this.m_radioPair.CheckedChanged += new System.EventHandler(this.m_radioPair_CheckedChanged);
            // 
            // m_radioSingle
            // 
            this.m_radioSingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_radioSingle.AutoSize = true;
            this.m_radioSingle.Checked = true;
            this.m_radioSingle.Location = new System.Drawing.Point(43, 3);
            this.m_radioSingle.Name = "m_radioSingle";
            this.m_radioSingle.Size = new System.Drawing.Size(82, 24);
            this.m_radioSingle.TabIndex = 0;
            this.m_radioSingle.TabStop = true;
            this.m_radioSingle.Text = "Single Edge";
            this.m_radioSingle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.m_radioSingle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.m_radioPair, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.m_gbEdge1Polarity, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.m_NumEdgePairWidth, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 168);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // m_gbEdge1Polarity
            // 
            this.m_gbEdge1Polarity.Controls.Add(this.m_Any1);
            this.m_gbEdge1Polarity.Controls.Add(this.m_LD1);
            this.m_gbEdge1Polarity.Controls.Add(this.m_DL1);
            this.m_gbEdge1Polarity.Enabled = false;
            this.m_gbEdge1Polarity.Location = new System.Drawing.Point(131, 33);
            this.m_gbEdge1Polarity.Name = "m_gbEdge1Polarity";
            this.m_gbEdge1Polarity.Size = new System.Drawing.Size(123, 99);
            this.m_gbEdge1Polarity.TabIndex = 3;
            this.m_gbEdge1Polarity.TabStop = false;
            this.m_gbEdge1Polarity.Text = "Edge 1 Polarity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_Any0);
            this.groupBox3.Controls.Add(this.m_LD0);
            this.groupBox3.Controls.Add(this.m_DL0);
            this.groupBox3.Location = new System.Drawing.Point(3, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 99);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edge 0 Polarity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Edge Pair Width";
            // 
            // m_NumEdgePairWidth
            // 
            this.m_NumEdgePairWidth.Enabled = false;
            this.m_NumEdgePairWidth.Location = new System.Drawing.Point(131, 138);
            this.m_NumEdgePairWidth.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.m_NumEdgePairWidth.Name = "m_NumEdgePairWidth";
            this.m_NumEdgePairWidth.Size = new System.Drawing.Size(120, 20);
            this.m_NumEdgePairWidth.TabIndex = 5;
            this.m_NumEdgePairWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_NumEdgePairWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // m_DL0
            // 
            this.m_DL0.AutoSize = true;
            this.m_DL0.Location = new System.Drawing.Point(10, 20);
            this.m_DL0.Name = "m_DL0";
            this.m_DL0.Size = new System.Drawing.Size(86, 17);
            this.m_DL0.TabIndex = 0;
            this.m_DL0.Text = "Dark to Light";
            this.m_DL0.UseVisualStyleBackColor = true;
            this.m_DL0.CheckedChanged += new System.EventHandler(this.edge0_CheckedChanged);
            // 
            // m_LD0
            // 
            this.m_LD0.AutoSize = true;
            this.m_LD0.Location = new System.Drawing.Point(10, 44);
            this.m_LD0.Name = "m_LD0";
            this.m_LD0.Size = new System.Drawing.Size(86, 17);
            this.m_LD0.TabIndex = 1;
            this.m_LD0.Text = "Light to Dark";
            this.m_LD0.UseVisualStyleBackColor = true;
            this.m_LD0.CheckedChanged += new System.EventHandler(this.edge0_CheckedChanged);
            // 
            // m_Any0
            // 
            this.m_Any0.AutoSize = true;
            this.m_Any0.Checked = true;
            this.m_Any0.Location = new System.Drawing.Point(10, 68);
            this.m_Any0.Name = "m_Any0";
            this.m_Any0.Size = new System.Drawing.Size(80, 17);
            this.m_Any0.TabIndex = 2;
            this.m_Any0.TabStop = true;
            this.m_Any0.Text = "Any Polarity";
            this.m_Any0.UseVisualStyleBackColor = true;
            this.m_Any0.CheckedChanged += new System.EventHandler(this.edge0_CheckedChanged);
            // 
            // m_DL1
            // 
            this.m_DL1.AutoSize = true;
            this.m_DL1.Location = new System.Drawing.Point(7, 20);
            this.m_DL1.Name = "m_DL1";
            this.m_DL1.Size = new System.Drawing.Size(86, 17);
            this.m_DL1.TabIndex = 0;
            this.m_DL1.Text = "Dark to Light";
            this.m_DL1.UseVisualStyleBackColor = true;
            this.m_DL1.CheckedChanged += new System.EventHandler(this.edge1_CheckedChanged);
            // 
            // m_LD1
            // 
            this.m_LD1.AutoSize = true;
            this.m_LD1.Location = new System.Drawing.Point(7, 44);
            this.m_LD1.Name = "m_LD1";
            this.m_LD1.Size = new System.Drawing.Size(86, 17);
            this.m_LD1.TabIndex = 1;
            this.m_LD1.Text = "Light to Dark";
            this.m_LD1.UseVisualStyleBackColor = true;
            this.m_LD1.CheckedChanged += new System.EventHandler(this.edge1_CheckedChanged);
            // 
            // m_Any1
            // 
            this.m_Any1.AutoSize = true;
            this.m_Any1.Checked = true;
            this.m_Any1.Location = new System.Drawing.Point(7, 68);
            this.m_Any1.Name = "m_Any1";
            this.m_Any1.Size = new System.Drawing.Size(80, 17);
            this.m_Any1.TabIndex = 2;
            this.m_Any1.TabStop = true;
            this.m_Any1.Text = "Any Polarity";
            this.m_Any1.UseVisualStyleBackColor = true;
            this.m_Any1.CheckedChanged += new System.EventHandler(this.edge1_CheckedChanged);
            // 
            // m_CaliperRes
            // 
            this.m_CaliperRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_CaliperRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_CaliperRes.Location = new System.Drawing.Point(3, 3);
            this.m_CaliperRes.Name = "m_CaliperRes";
            this.m_CaliperRes.ReadOnly = true;
            this.m_CaliperRes.RowHeadersVisible = false;
            this.m_CaliperRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_CaliperRes.Size = new System.Drawing.Size(263, 355);
            this.m_CaliperRes.TabIndex = 0;
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplay1.Location = new System.Drawing.Point(303, 0);
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.SelectedRecordKey = null;
            this.cogDisplay1.ShowRecordsDropDown = true;
            this.cogDisplay1.Size = new System.Drawing.Size(497, 450);
            this.cogDisplay1.TabIndex = 3;
            this.cogDisplay1.Tool = null;
            this.cogDisplay1.ToolSyncObject = null;
            this.cogDisplay1.UserRecord = null;
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
            this.m_HistogramOutput.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.m_HisOutTable.ResumeLayout(false);
            this.m_HisOutTable.PerformLayout();
            this.m_BlobTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.m_CaliperTab.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.m_CaliperInput.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.m_gbEdgeMode.ResumeLayout(false);
            this.m_CaliperOutput.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumContrastThreshold)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.m_gbEdge1Polarity.ResumeLayout(false);
            this.m_gbEdge1Polarity.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumEdgePairWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_CaliperRes)).EndInit();
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
        private System.Windows.Forms.TabPage m_BlobInput;
        private System.Windows.Forms.TabPage m_BlobOutput;
        private System.Windows.Forms.TabPage m_CaliperTab;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage m_CaliperInput;
        private System.Windows.Forms.TabPage m_CaliperOutput;
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
        private System.Windows.Forms.GroupBox m_gbEdgeMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown m_NumResult;
        private System.Windows.Forms.NumericUpDown m_NumFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown m_NumContrastThreshold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton m_radioSingle;
        private System.Windows.Forms.RadioButton m_radioPair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox m_gbEdge1Polarity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown m_NumEdgePairWidth;
        private System.Windows.Forms.RadioButton m_Any0;
        private System.Windows.Forms.RadioButton m_LD0;
        private System.Windows.Forms.RadioButton m_DL0;
        private System.Windows.Forms.RadioButton m_Any1;
        private System.Windows.Forms.RadioButton m_LD1;
        private System.Windows.Forms.RadioButton m_DL1;
        private System.Windows.Forms.DataGridView m_CaliperRes;
        private Cognex.VisionPro.CogToolDisplay cogDisplay1;
    }
}

