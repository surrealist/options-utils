namespace OrderSimplifier
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.num = new System.Windows.Forms.NumericUpDown();
      this.button1 = new System.Windows.Forms.Button();
      this.panel4 = new System.Windows.Forms.Panel();
      this.chkAverage = new System.Windows.Forms.CheckBox();
      this.chkAutoCopy = new System.Windows.Forms.CheckBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.chkAutoSelectText = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblLines = new System.Windows.Forms.ToolStripStatusLabel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rdLF = new System.Windows.Forms.RadioButton();
      this.rdSF = new System.Windows.Forms.RadioButton();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numVolume = new System.Windows.Forms.NumericUpDown();
      this.numCount = new System.Windows.Forms.NumericUpDown();
      this.numSteps = new System.Windows.Forms.NumericUpDown();
      this.numStartIndex = new System.Windows.Forms.NumericUpDown();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.btnBrokerOrders = new System.Windows.Forms.Button();
      this.txtBrokerOrders = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
      this.panel4.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSteps)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).BeginInit();
      this.tabPage3.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.num);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.panel4);
      this.panel1.Controls.Add(this.chkAutoSelectText);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(189, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(255, 330);
      this.panel1.TabIndex = 2;
      // 
      // num
      // 
      this.num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.num.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::OrderSimplifier.Properties.Settings.Default, "SimplifyMultiplier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.num.Location = new System.Drawing.Point(126, 18);
      this.num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.num.Name = "num";
      this.num.Size = new System.Drawing.Size(123, 44);
      this.num.TabIndex = 1;
      this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.num.Value = global::OrderSimplifier.Properties.Settings.Default.SimplifyMultiplier;
      this.num.ValueChanged += new System.EventHandler(this.Num_ValueChanged);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.button1.Location = new System.Drawing.Point(6, 56);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(243, 57);
      this.button1.TabIndex = 0;
      this.button1.Text = "Simplify >>";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.chkAverage);
      this.panel4.Controls.Add(this.chkAutoCopy);
      this.panel4.Controls.Add(this.checkBox1);
      this.panel4.Controls.Add(this.label6);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(255, 330);
      this.panel4.TabIndex = 4;
      // 
      // chkAverage
      // 
      this.chkAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.chkAverage.AutoSize = true;
      this.chkAverage.Checked = global::OrderSimplifier.Properties.Settings.Default.SimplifyAveragePremium;
      this.chkAverage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OrderSimplifier.Properties.Settings.Default, "SimplifyAveragePremium", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.chkAverage.Location = new System.Drawing.Point(6, 299);
      this.chkAverage.Name = "chkAverage";
      this.chkAverage.Size = new System.Drawing.Size(242, 26);
      this.chkAverage.TabIndex = 4;
      this.chkAverage.Text = "Average Strike\'s Premium";
      this.chkAverage.UseVisualStyleBackColor = true;
      this.chkAverage.CheckedChanged += new System.EventHandler(this.ChkAverage_CheckedChanged);
      // 
      // chkAutoCopy
      // 
      this.chkAutoCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.chkAutoCopy.AutoSize = true;
      this.chkAutoCopy.Checked = global::OrderSimplifier.Properties.Settings.Default.SimplifyAutoCopy;
      this.chkAutoCopy.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkAutoCopy.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OrderSimplifier.Properties.Settings.Default, "SimplifyAutoCopy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkAutoCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.chkAutoCopy.Location = new System.Drawing.Point(6, 274);
      this.chkAutoCopy.Name = "chkAutoCopy";
      this.chkAutoCopy.Size = new System.Drawing.Size(308, 26);
      this.chkAutoCopy.TabIndex = 3;
      this.chkAutoCopy.Text = "Copy Output to Clipboard on Click";
      this.chkAutoCopy.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = global::OrderSimplifier.Properties.Settings.Default.SimplifyAutoSelectText;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OrderSimplifier.Properties.Settings.Default, "SimplifyAutoSelectText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.checkBox1.Location = new System.Drawing.Point(6, 249);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(169, 26);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "Auto Select Text";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label6.Location = new System.Drawing.Point(88, 13);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 55);
      this.label6.TabIndex = 2;
      this.label6.Text = "x";
      // 
      // chkAutoSelectText
      // 
      this.chkAutoSelectText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.chkAutoSelectText.AutoSize = true;
      this.chkAutoSelectText.Checked = global::OrderSimplifier.Properties.Settings.Default.SimplifyAutoSelectText;
      this.chkAutoSelectText.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkAutoSelectText.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OrderSimplifier.Properties.Settings.Default, "SimplifyAutoSelectText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkAutoSelectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.chkAutoSelectText.Location = new System.Drawing.Point(6, 301);
      this.chkAutoSelectText.Name = "chkAutoSelectText";
      this.chkAutoSelectText.Size = new System.Drawing.Size(169, 26);
      this.chkAutoSelectText.TabIndex = 3;
      this.chkAutoSelectText.Text = "Auto Select Text";
      this.chkAutoSelectText.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label1.Location = new System.Drawing.Point(88, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 55);
      this.label1.TabIndex = 2;
      this.label1.Text = "x";
      // 
      // txtOutput
      // 
      this.txtOutput.BackColor = System.Drawing.Color.Beige;
      this.txtOutput.Cursor = System.Windows.Forms.Cursors.Hand;
      this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtOutput.Location = new System.Drawing.Point(0, 59);
      this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtOutput.Size = new System.Drawing.Size(210, 313);
      this.txtOutput.TabIndex = 3;
      this.txtOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox2_MouseClick);
      this.txtOutput.TextChanged += new System.EventHandler(this.TxtOutput_TextChanged);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLines});
      this.statusStrip1.Location = new System.Drawing.Point(0, 405);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(669, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblLines
      // 
      this.lblLines.Name = "lblLines";
      this.lblLines.Size = new System.Drawing.Size(654, 15);
      this.lblLines.Spring = true;
      this.lblLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txtOutput);
      this.panel2.Controls.Add(this.panel5);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel2.Location = new System.Drawing.Point(455, 33);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
      this.panel2.Size = new System.Drawing.Size(214, 372);
      this.panel2.TabIndex = 6;
      // 
      // panel5
      // 
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(0, 53);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(210, 6);
      this.panel5.TabIndex = 6;
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.Color.RoyalBlue;
      this.label7.Dock = System.Windows.Forms.DockStyle.Top;
      this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label7.Location = new System.Drawing.Point(0, 30);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(210, 23);
      this.label7.TabIndex = 5;
      this.label7.Text = "Output";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.linkLabel1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(210, 30);
      this.panel3.TabIndex = 4;
      // 
      // linkLabel1
      // 
      this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.linkLabel1.LinkColor = System.Drawing.Color.MediumBlue;
      this.linkLabel1.Location = new System.Drawing.Point(0, 0);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(210, 30);
      this.linkLabel1.TabIndex = 0;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "https://OptionsGo.Net";
      this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.tabControl1.Location = new System.Drawing.Point(0, 33);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.Padding = new System.Drawing.Point(9, 2);
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(455, 372);
      this.tabControl1.TabIndex = 7;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.tabPage1.Controls.Add(this.panel1);
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 32);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(447, 336);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Orders Simplifier";
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OrderSimplifier.Properties.Settings.Default, "SourceText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(3, 3);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(186, 330);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = global::OrderSimplifier.Properties.Settings.Default.SourceText;
      this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox1_MouseClick);
      this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
      this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.numVolume);
      this.tabPage2.Controls.Add(this.numCount);
      this.tabPage2.Controls.Add(this.numSteps);
      this.tabPage2.Controls.Add(this.numStartIndex);
      this.tabPage2.Location = new System.Drawing.Point(4, 32);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(447, 336);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Fu Simulation";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rdLF);
      this.groupBox1.Controls.Add(this.rdSF);
      this.groupBox1.Location = new System.Drawing.Point(37, 76);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(115, 141);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      // 
      // rdLF
      // 
      this.rdLF.AutoSize = true;
      this.rdLF.Checked = global::OrderSimplifier.Properties.Settings.Default.SimulationLF;
      this.rdLF.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OrderSimplifier.Properties.Settings.Default, "SimulationLF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.rdLF.Location = new System.Drawing.Point(26, 40);
      this.rdLF.Name = "rdLF";
      this.rdLF.Size = new System.Drawing.Size(60, 29);
      this.rdLF.TabIndex = 0;
      this.rdLF.TabStop = true;
      this.rdLF.Text = "LF";
      this.rdLF.UseVisualStyleBackColor = true;
      this.rdLF.CheckedChanged += new System.EventHandler(this.RdLF_CheckedChanged);
      // 
      // rdSF
      // 
      this.rdSF.AutoSize = true;
      this.rdSF.Location = new System.Drawing.Point(26, 85);
      this.rdSF.Name = "rdSF";
      this.rdSF.Size = new System.Drawing.Size(63, 29);
      this.rdSF.TabIndex = 1;
      this.rdSF.Text = "SF";
      this.rdSF.UseVisualStyleBackColor = true;
      this.rdSF.CheckedChanged += new System.EventHandler(this.RdSF_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(180, 104);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(102, 25);
      this.label5.TabIndex = 9;
      this.label5.Text = "Contracts:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(180, 250);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(71, 25);
      this.label4.TabIndex = 7;
      this.label4.Text = "Count:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(180, 177);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 25);
      this.label3.TabIndex = 6;
      this.label3.Text = "Steps:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(180, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "Start Index:";
      // 
      // numVolume
      // 
      this.numVolume.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::OrderSimplifier.Properties.Settings.Default, "SimulationContracts", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numVolume.Location = new System.Drawing.Point(184, 131);
      this.numVolume.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numVolume.Name = "numVolume";
      this.numVolume.Size = new System.Drawing.Size(120, 30);
      this.numVolume.TabIndex = 12;
      this.numVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numVolume.Value = global::OrderSimplifier.Properties.Settings.Default.SimulationContracts;
      this.numVolume.ValueChanged += new System.EventHandler(this.NumVolume_ValueChanged);
      // 
      // numCount
      // 
      this.numCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::OrderSimplifier.Properties.Settings.Default, "SimulationCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numCount.Location = new System.Drawing.Point(184, 277);
      this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numCount.Name = "numCount";
      this.numCount.Size = new System.Drawing.Size(120, 30);
      this.numCount.TabIndex = 14;
      this.numCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numCount.Value = global::OrderSimplifier.Properties.Settings.Default.SimulationCount;
      this.numCount.ValueChanged += new System.EventHandler(this.NumCount_ValueChanged);
      // 
      // numSteps
      // 
      this.numSteps.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::OrderSimplifier.Properties.Settings.Default, "SimulationSteps", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numSteps.DecimalPlaces = 1;
      this.numSteps.Location = new System.Drawing.Point(184, 204);
      this.numSteps.Name = "numSteps";
      this.numSteps.Size = new System.Drawing.Size(120, 30);
      this.numSteps.TabIndex = 13;
      this.numSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numSteps.Value = global::OrderSimplifier.Properties.Settings.Default.SimulationSteps;
      this.numSteps.ValueChanged += new System.EventHandler(this.NumSteps_ValueChanged);
      // 
      // numStartIndex
      // 
      this.numStartIndex.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::OrderSimplifier.Properties.Settings.Default, "SimulationStartIndex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numStartIndex.DecimalPlaces = 1;
      this.numStartIndex.Location = new System.Drawing.Point(184, 54);
      this.numStartIndex.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.numStartIndex.Name = "numStartIndex";
      this.numStartIndex.Size = new System.Drawing.Size(120, 30);
      this.numStartIndex.TabIndex = 11;
      this.numStartIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numStartIndex.Value = global::OrderSimplifier.Properties.Settings.Default.SimulationStartIndex;
      this.numStartIndex.ValueChanged += new System.EventHandler(this.NumStartIndex_ValueChanged);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.btnBrokerOrders);
      this.tabPage3.Controls.Add(this.txtBrokerOrders);
      this.tabPage3.Location = new System.Drawing.Point(4, 32);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(447, 345);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Confirmation Note";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // btnBrokerOrders
      // 
      this.btnBrokerOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrokerOrders.Location = new System.Drawing.Point(338, 7);
      this.btnBrokerOrders.Name = "btnBrokerOrders";
      this.btnBrokerOrders.Size = new System.Drawing.Size(103, 59);
      this.btnBrokerOrders.TabIndex = 1;
      this.btnBrokerOrders.Text = ">>";
      this.btnBrokerOrders.UseVisualStyleBackColor = true;
      this.btnBrokerOrders.Click += new System.EventHandler(this.btnBrokerOrders_Click);
      // 
      // txtBrokerOrders
      // 
      this.txtBrokerOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBrokerOrders.Location = new System.Drawing.Point(0, 7);
      this.txtBrokerOrders.Multiline = true;
      this.txtBrokerOrders.Name = "txtBrokerOrders";
      this.txtBrokerOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtBrokerOrders.Size = new System.Drawing.Size(332, 341);
      this.txtBrokerOrders.TabIndex = 0;
      this.txtBrokerOrders.Text = "S50H20 BU-99999999-88888 L Open 1 1,058.00 0.00 17.76 1.24 0.00 19.00\r\nS50H20 SE-" +
    "99999999-88889 S Close 1 1,058.00 0.00 17.76 1.24 0.00 19.00";
      this.txtBrokerOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBrokerOrders_MouseClick);
      this.txtBrokerOrders.Enter += new System.EventHandler(this.txtBrokerOrders_Enter);
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(669, 33);
      this.menuStrip1.TabIndex = 8;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(669, 427);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.statusStrip1);
      this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(550, 56);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "OptionsGo.Net Utilities";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSteps)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.NumericUpDown num;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblLines;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numCount;
    private System.Windows.Forms.NumericUpDown numSteps;
    private System.Windows.Forms.NumericUpDown numStartIndex;
    private System.Windows.Forms.RadioButton rdSF;
    private System.Windows.Forms.RadioButton rdLF;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numVolume;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.CheckBox chkAutoSelectText;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.CheckBox chkAutoCopy;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox chkAverage;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBrokerOrders;
        private System.Windows.Forms.TextBox txtBrokerOrders;
    }
}

