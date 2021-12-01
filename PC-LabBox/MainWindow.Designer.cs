
namespace PC_LabBox
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.sampleText = new System.Windows.Forms.TextBox();
            this.sampleTimeBar = new System.Windows.Forms.TrackBar();
            this.serialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SerialMonitor = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.stopButton = new MaterialSkin.Controls.MaterialButton();
            this.startButton = new MaterialSkin.Controls.MaterialButton();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.serialConnectionButton = new MaterialSkin.Controls.MaterialButton();
            this.managingEmailButton = new MaterialSkin.Controls.MaterialButton();
            this.authorizedEmailsButton = new MaterialSkin.Controls.MaterialButton();
            this.serialConnectionPanel = new MaterialSkin.Controls.MaterialCard();
            this.label6 = new System.Windows.Forms.Label();
            this.serialSpeedBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPortBox = new System.Windows.Forms.ComboBox();
            this.ConnectSerialButton = new MaterialSkin.Controls.MaterialButton();
            this.DisconnectSerialButton = new MaterialSkin.Controls.MaterialButton();
            this.managingEmailPanel = new MaterialSkin.Controls.MaterialCard();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordField = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.emailField = new MaterialSkin.Controls.MaterialTextBox();
            this.authorizedEmailsPanel = new MaterialSkin.Controls.MaterialCard();
            this.emailListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.addEmailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customPanel = new System.Windows.Forms.Panel();
            this.stopCondition = new System.Windows.Forms.TextBox();
            this.startCondition = new System.Windows.Forms.TextBox();
            this.stopCommand = new System.Windows.Forms.CheckBox();
            this.startCommand = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioDefaultSettings = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTimeBar)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.serialConnectionPanel.SuspendLayout();
            this.managingEmailPanel.SuspendLayout();
            this.authorizedEmailsPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.customPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.materialTabControl1.Controls.Add(this.homeTab);
            this.materialTabControl1.Controls.Add(this.settingsTab);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(894, 354);
            this.materialTabControl1.TabIndex = 3;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.White;
            this.homeTab.Controls.Add(this.label5);
            this.homeTab.Controls.Add(this.sampleText);
            this.homeTab.Controls.Add(this.sampleTimeBar);
            this.homeTab.Controls.Add(this.serialLabel);
            this.homeTab.Controls.Add(this.SerialMonitor);
            this.homeTab.Controls.Add(this.stopButton);
            this.homeTab.Controls.Add(this.startButton);
            this.homeTab.Location = new System.Drawing.Point(4, 24);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(886, 326);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.Click += new System.EventHandler(this.homeTab_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(640, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select the sampling time:\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sampleText
            // 
            this.sampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleText.Enabled = false;
            this.sampleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleText.Location = new System.Drawing.Point(709, 221);
            this.sampleText.Name = "sampleText";
            this.sampleText.Size = new System.Drawing.Size(43, 22);
            this.sampleText.TabIndex = 9;
            this.sampleText.Text = "1s";
            this.sampleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sampleTimeBar
            // 
            this.sampleTimeBar.BackColor = System.Drawing.Color.White;
            this.sampleTimeBar.Location = new System.Drawing.Point(640, 170);
            this.sampleTimeBar.Maximum = 30;
            this.sampleTimeBar.Minimum = 1;
            this.sampleTimeBar.Name = "sampleTimeBar";
            this.sampleTimeBar.Size = new System.Drawing.Size(175, 45);
            this.sampleTimeBar.TabIndex = 7;
            this.sampleTimeBar.Value = 1;
            this.sampleTimeBar.Scroll += new System.EventHandler(this.sampleTimeBar_Scroll);
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.BackColor = System.Drawing.Color.White;
            this.serialLabel.Depth = 0;
            this.serialLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.serialLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.serialLabel.ForeColor = System.Drawing.Color.Transparent;
            this.serialLabel.Location = new System.Drawing.Point(15, 12);
            this.serialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(151, 29);
            this.serialLabel.TabIndex = 4;
            this.serialLabel.Text = "Serial monitor";
            // 
            // SerialMonitor
            // 
            this.SerialMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SerialMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialMonitor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SerialMonitor.Depth = 0;
            this.SerialMonitor.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SerialMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SerialMonitor.Location = new System.Drawing.Point(15, 51);
            this.SerialMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerialMonitor.Name = "SerialMonitor";
            this.SerialMonitor.Size = new System.Drawing.Size(618, 272);
            this.SerialMonitor.TabIndex = 3;
            this.SerialMonitor.Text = "Data sampling will appear here...";
            this.SerialMonitor.TextChanged += new System.EventHandler(this.SerialMonitor_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = false;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stopButton.Depth = 0;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.HighEmphasis = true;
            this.stopButton.Icon = null;
            this.stopButton.Location = new System.Drawing.Point(739, 54);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(76, 33);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "STOP";
            this.stopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stopButton.UseAccentColor = false;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = false;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startButton.Depth = 0;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.startButton.FlatAppearance.BorderSize = 20;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.HighEmphasis = true;
            this.startButton.Icon = null;
            this.startButton.Location = new System.Drawing.Point(640, 52);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(76, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startButton.UseAccentColor = false;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.White;
            this.settingsTab.Controls.Add(this.serialConnectionButton);
            this.settingsTab.Controls.Add(this.managingEmailButton);
            this.settingsTab.Controls.Add(this.authorizedEmailsButton);
            this.settingsTab.Controls.Add(this.serialConnectionPanel);
            this.settingsTab.Controls.Add(this.managingEmailPanel);
            this.settingsTab.Controls.Add(this.authorizedEmailsPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 24);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(886, 326);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            // 
            // serialConnectionButton
            // 
            this.serialConnectionButton.AutoSize = false;
            this.serialConnectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serialConnectionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.serialConnectionButton.Depth = 0;
            this.serialConnectionButton.HighEmphasis = true;
            this.serialConnectionButton.Icon = null;
            this.serialConnectionButton.Location = new System.Drawing.Point(4, 128);
            this.serialConnectionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.serialConnectionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.serialConnectionButton.Name = "serialConnectionButton";
            this.serialConnectionButton.Size = new System.Drawing.Size(255, 45);
            this.serialConnectionButton.TabIndex = 11;
            this.serialConnectionButton.Text = "Serial connection";
            this.serialConnectionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.serialConnectionButton.UseAccentColor = false;
            this.serialConnectionButton.UseVisualStyleBackColor = true;
            this.serialConnectionButton.Click += new System.EventHandler(this.serialConnectionButton_Click);
            // 
            // managingEmailButton
            // 
            this.managingEmailButton.AutoSize = false;
            this.managingEmailButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.managingEmailButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.managingEmailButton.Depth = 0;
            this.managingEmailButton.HighEmphasis = true;
            this.managingEmailButton.Icon = null;
            this.managingEmailButton.Location = new System.Drawing.Point(4, 71);
            this.managingEmailButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.managingEmailButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.managingEmailButton.Name = "managingEmailButton";
            this.managingEmailButton.Size = new System.Drawing.Size(255, 45);
            this.managingEmailButton.TabIndex = 5;
            this.managingEmailButton.Text = "Edit managing email";
            this.managingEmailButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.managingEmailButton.UseAccentColor = false;
            this.managingEmailButton.UseVisualStyleBackColor = true;
            this.managingEmailButton.Click += new System.EventHandler(this.managingEmailButton_Click);
            // 
            // authorizedEmailsButton
            // 
            this.authorizedEmailsButton.AutoSize = false;
            this.authorizedEmailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorizedEmailsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.authorizedEmailsButton.Depth = 0;
            this.authorizedEmailsButton.HighEmphasis = true;
            this.authorizedEmailsButton.Icon = null;
            this.authorizedEmailsButton.Location = new System.Drawing.Point(4, 14);
            this.authorizedEmailsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authorizedEmailsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorizedEmailsButton.Name = "authorizedEmailsButton";
            this.authorizedEmailsButton.Size = new System.Drawing.Size(255, 45);
            this.authorizedEmailsButton.TabIndex = 4;
            this.authorizedEmailsButton.Text = "Authorized emails";
            this.authorizedEmailsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.authorizedEmailsButton.UseAccentColor = false;
            this.authorizedEmailsButton.UseVisualStyleBackColor = true;
            this.authorizedEmailsButton.Click += new System.EventHandler(this.authorizedEmailsButton_Click);
            // 
            // serialConnectionPanel
            // 
            this.serialConnectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serialConnectionPanel.Controls.Add(this.label6);
            this.serialConnectionPanel.Controls.Add(this.serialSpeedBox);
            this.serialConnectionPanel.Controls.Add(this.label3);
            this.serialConnectionPanel.Controls.Add(this.label2);
            this.serialConnectionPanel.Controls.Add(this.label1);
            this.serialConnectionPanel.Controls.Add(this.serialPortBox);
            this.serialConnectionPanel.Controls.Add(this.ConnectSerialButton);
            this.serialConnectionPanel.Controls.Add(this.DisconnectSerialButton);
            this.serialConnectionPanel.Depth = 0;
            this.serialConnectionPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serialConnectionPanel.Location = new System.Drawing.Point(277, 14);
            this.serialConnectionPanel.Margin = new System.Windows.Forms.Padding(14);
            this.serialConnectionPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.serialConnectionPanel.Name = "serialConnectionPanel";
            this.serialConnectionPanel.Padding = new System.Windows.Forms.Padding(14);
            this.serialConnectionPanel.Size = new System.Drawing.Size(518, 298);
            this.serialConnectionPanel.TabIndex = 10;
            this.serialConnectionPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Serial connection";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // serialSpeedBox
            // 
            this.serialSpeedBox.DisplayMember = "115200";
            this.serialSpeedBox.FormattingEnabled = true;
            this.serialSpeedBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200",
            ""});
            this.serialSpeedBox.Location = new System.Drawing.Point(214, 79);
            this.serialSpeedBox.Name = "serialSpeedBox";
            this.serialSpeedBox.Size = new System.Drawing.Size(129, 23);
            this.serialSpeedBox.TabIndex = 18;
            this.serialSpeedBox.Tag = "";
            this.serialSpeedBox.Text = "115200";
            this.serialSpeedBox.SelectedIndexChanged += new System.EventHandler(this.serialSpeedBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(214, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Serial speed [BPS]";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 105);
            this.label2.TabIndex = 16;
            this.label2.Text = "To find the LabBox USB connection port:\r\n1 - Click on right side on button mouse " +
    "on top of windows icon.\r\n2 - Then select the Device Manager\r\n\r\n\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Serial connection port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serialPortBox
            // 
            this.serialPortBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.serialPortBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serialPortBox.Items.AddRange(new object[] {
            "COM1"});
            this.serialPortBox.Location = new System.Drawing.Point(23, 79);
            this.serialPortBox.Name = "serialPortBox";
            this.serialPortBox.Size = new System.Drawing.Size(153, 23);
            this.serialPortBox.TabIndex = 14;
            this.serialPortBox.Text = "COM1";
            this.serialPortBox.SelectedIndexChanged += new System.EventHandler(this.serialPortBox_SelectedIndexChanged);
            // 
            // ConnectSerialButton
            // 
            this.ConnectSerialButton.AutoSize = false;
            this.ConnectSerialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectSerialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ConnectSerialButton.Depth = 0;
            this.ConnectSerialButton.HighEmphasis = true;
            this.ConnectSerialButton.Icon = null;
            this.ConnectSerialButton.Location = new System.Drawing.Point(402, 73);
            this.ConnectSerialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConnectSerialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConnectSerialButton.Name = "ConnectSerialButton";
            this.ConnectSerialButton.Size = new System.Drawing.Size(98, 33);
            this.ConnectSerialButton.TabIndex = 13;
            this.ConnectSerialButton.Text = "Connect";
            this.ConnectSerialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ConnectSerialButton.UseAccentColor = false;
            this.ConnectSerialButton.UseVisualStyleBackColor = true;
            this.ConnectSerialButton.Click += new System.EventHandler(this.ConnectSerialButton_Click);
            // 
            // DisconnectSerialButton
            // 
            this.DisconnectSerialButton.AutoSize = false;
            this.DisconnectSerialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisconnectSerialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DisconnectSerialButton.Depth = 0;
            this.DisconnectSerialButton.HighEmphasis = true;
            this.DisconnectSerialButton.Icon = null;
            this.DisconnectSerialButton.Location = new System.Drawing.Point(402, 118);
            this.DisconnectSerialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DisconnectSerialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisconnectSerialButton.Name = "DisconnectSerialButton";
            this.DisconnectSerialButton.Size = new System.Drawing.Size(98, 33);
            this.DisconnectSerialButton.TabIndex = 12;
            this.DisconnectSerialButton.Text = "Disconnect";
            this.DisconnectSerialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DisconnectSerialButton.UseAccentColor = false;
            this.DisconnectSerialButton.UseVisualStyleBackColor = true;
            this.DisconnectSerialButton.Click += new System.EventHandler(this.DisconnectSerialButton_Click);
            // 
            // managingEmailPanel
            // 
            this.managingEmailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.managingEmailPanel.Controls.Add(this.label7);
            this.managingEmailPanel.Controls.Add(this.passwordField);
            this.managingEmailPanel.Controls.Add(this.passwordLabel);
            this.managingEmailPanel.Controls.Add(this.emailLabel);
            this.managingEmailPanel.Controls.Add(this.saveButton);
            this.managingEmailPanel.Controls.Add(this.emailField);
            this.managingEmailPanel.Depth = 0;
            this.managingEmailPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.managingEmailPanel.Location = new System.Drawing.Point(277, 14);
            this.managingEmailPanel.Margin = new System.Windows.Forms.Padding(14);
            this.managingEmailPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.managingEmailPanel.Name = "managingEmailPanel";
            this.managingEmailPanel.Padding = new System.Windows.Forms.Padding(14);
            this.managingEmailPanel.Size = new System.Drawing.Size(518, 298);
            this.managingEmailPanel.TabIndex = 7;
            this.managingEmailPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Edit managing email";
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Depth = 0;
            this.passwordField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordField.LeadingIcon = null;
            this.passwordField.Location = new System.Drawing.Point(23, 178);
            this.passwordField.MaxLength = 50;
            this.passwordField.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordField.Multiline = false;
            this.passwordField.Name = "passwordField";
            this.passwordField.Password = true;
            this.passwordField.Size = new System.Drawing.Size(485, 50);
            this.passwordField.TabIndex = 7;
            this.passwordField.Text = "";
            this.passwordField.TrailingIcon = null;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(23, 156);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 19);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailLabel.Location = new System.Drawing.Point(23, 71);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 19);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(23, 243);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 36);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "SAVE";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailField
            // 
            this.emailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailField.Depth = 0;
            this.emailField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailField.LeadingIcon = null;
            this.emailField.Location = new System.Drawing.Point(23, 93);
            this.emailField.MaxLength = 50;
            this.emailField.MouseState = MaterialSkin.MouseState.OUT;
            this.emailField.Multiline = false;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(485, 50);
            this.emailField.TabIndex = 6;
            this.emailField.Text = "";
            this.emailField.TrailingIcon = null;
            // 
            // authorizedEmailsPanel
            // 
            this.authorizedEmailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.authorizedEmailsPanel.Controls.Add(this.emailListBox);
            this.authorizedEmailsPanel.Controls.Add(this.label8);
            this.authorizedEmailsPanel.Controls.Add(this.materialButton1);
            this.authorizedEmailsPanel.Controls.Add(this.addButton);
            this.authorizedEmailsPanel.Controls.Add(this.addEmailTextBox);
            this.authorizedEmailsPanel.Depth = 0;
            this.authorizedEmailsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.authorizedEmailsPanel.Location = new System.Drawing.Point(277, 14);
            this.authorizedEmailsPanel.Margin = new System.Windows.Forms.Padding(14);
            this.authorizedEmailsPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorizedEmailsPanel.Name = "authorizedEmailsPanel";
            this.authorizedEmailsPanel.Padding = new System.Windows.Forms.Padding(14);
            this.authorizedEmailsPanel.Size = new System.Drawing.Size(518, 298);
            this.authorizedEmailsPanel.TabIndex = 10;
            this.authorizedEmailsPanel.Visible = false;
            // 
            // emailListBox
            // 
            this.emailListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailListBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailListBox.FormattingEnabled = true;
            this.emailListBox.ItemHeight = 15;
            this.emailListBox.Location = new System.Drawing.Point(17, 42);
            this.emailListBox.Name = "emailListBox";
            this.emailListBox.Size = new System.Drawing.Size(492, 167);
            this.emailListBox.TabIndex = 21;
            this.emailListBox.SelectedIndexChanged += new System.EventHandler(this.emailListBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Authorized emails";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(439, 229);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(69, 49);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "SAVE";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(362, 229);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 50);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "ADD";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addEmailTextBox
            // 
            this.addEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addEmailTextBox.Depth = 0;
            this.addEmailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addEmailTextBox.LeadingIcon = null;
            this.addEmailTextBox.Location = new System.Drawing.Point(17, 231);
            this.addEmailTextBox.MaxLength = 50;
            this.addEmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addEmailTextBox.Multiline = false;
            this.addEmailTextBox.Name = "addEmailTextBox";
            this.addEmailTextBox.Size = new System.Drawing.Size(338, 50);
            this.addEmailTextBox.TabIndex = 2;
            this.addEmailTextBox.Text = "";
            this.addEmailTextBox.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customPanel);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioDefaultSettings);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 326);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Configurations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customPanel
            // 
            this.customPanel.Controls.Add(this.stopCondition);
            this.customPanel.Controls.Add(this.startCondition);
            this.customPanel.Controls.Add(this.stopCommand);
            this.customPanel.Controls.Add(this.startCommand);
            this.customPanel.Location = new System.Drawing.Point(41, 82);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(396, 153);
            this.customPanel.TabIndex = 5;
            // 
            // stopCondition
            // 
            this.stopCondition.Enabled = false;
            this.stopCondition.Location = new System.Drawing.Point(25, 82);
            this.stopCondition.MaxLength = 12;
            this.stopCondition.Name = "stopCondition";
            this.stopCondition.Size = new System.Drawing.Size(99, 23);
            this.stopCondition.TabIndex = 6;
            this.stopCondition.Text = "stop";
            // 
            // startCondition
            // 
            this.startCondition.Enabled = false;
            this.startCondition.Location = new System.Drawing.Point(25, 28);
            this.startCondition.MaxLength = 12;
            this.startCondition.Name = "startCondition";
            this.startCondition.Size = new System.Drawing.Size(99, 23);
            this.startCondition.TabIndex = 5;
            this.startCondition.Text = "start";
            // 
            // stopCommand
            // 
            this.stopCommand.AutoSize = true;
            this.stopCommand.Location = new System.Drawing.Point(4, 57);
            this.stopCommand.Name = "stopCommand";
            this.stopCommand.Size = new System.Drawing.Size(290, 19);
            this.stopCommand.TabIndex = 4;
            this.stopCommand.Text = "Use custom command line to STOP data sampling";
            this.stopCommand.UseVisualStyleBackColor = true;
            this.stopCommand.CheckedChanged += new System.EventHandler(this.stopCommand_CheckedChanged);
            // 
            // startCommand
            // 
            this.startCommand.AutoSize = true;
            this.startCommand.Location = new System.Drawing.Point(4, 3);
            this.startCommand.Name = "startCommand";
            this.startCommand.Size = new System.Drawing.Size(294, 19);
            this.startCommand.TabIndex = 3;
            this.startCommand.Text = "Use custom command line to START data sampling";
            this.startCommand.UseVisualStyleBackColor = true;
            this.startCommand.CheckedChanged += new System.EventHandler(this.startCommand_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Customize";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioDefaultSettings
            // 
            this.radioDefaultSettings.AutoSize = true;
            this.radioDefaultSettings.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioDefaultSettings.Checked = true;
            this.radioDefaultSettings.Location = new System.Drawing.Point(26, 29);
            this.radioDefaultSettings.Name = "radioDefaultSettings";
            this.radioDefaultSettings.Size = new System.Drawing.Size(128, 19);
            this.radioDefaultSettings.TabIndex = 1;
            this.radioDefaultSettings.TabStop = true;
            this.radioDefaultSettings.Text = "Use default settings";
            this.radioDefaultSettings.UseVisualStyleBackColor = true;
            this.radioDefaultSettings.CheckedChanged += new System.EventHandler(this.radioDefaultSettings_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 326);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "About";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "The Laboratory Box Software was developed by Andrian Moldovan. \r\nFor any question" +
    "s or software bugs please report to a.moldovan@campus.fct.unl.pt\r\n\r\n\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 421);
            this.Controls.Add(this.materialTabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC-LabBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTimeBar)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.serialConnectionPanel.ResumeLayout(false);
            this.serialConnectionPanel.PerformLayout();
            this.managingEmailPanel.ResumeLayout(false);
            this.managingEmailPanel.PerformLayout();
            this.authorizedEmailsPanel.ResumeLayout(false);
            this.authorizedEmailsPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.customPanel.ResumeLayout(false);
            this.customPanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage settingsTab;
        private MaterialSkin.Controls.MaterialButton authorizedEmailsButton;
        private MaterialSkin.Controls.MaterialButton managingEmailButton;
        private MaterialSkin.Controls.MaterialCard managingEmailPanel;
        private MaterialSkin.Controls.MaterialTextBox emailField;
        private MaterialSkin.Controls.MaterialTextBox passwordField;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialCard authorizedEmailsPanel;
        private MaterialSkin.Controls.MaterialTextBox addEmailTextBox;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton serialConnectionButton;
        private MaterialSkin.Controls.MaterialCard serialConnectionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialPortBox;
        private MaterialSkin.Controls.MaterialButton ConnectSerialButton;
        private MaterialSkin.Controls.MaterialButton DisconnectSerialButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serialSpeedBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox emailListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox stopCommand;
        private System.Windows.Forms.CheckBox startCommand;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioDefaultSettings;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel customPanel;
        private System.Windows.Forms.TextBox stopCondition;
        private System.Windows.Forms.TextBox startCondition;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TrackBar sampleTimeBar;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialLabel serialLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox SerialMonitor;
        private MaterialSkin.Controls.MaterialButton stopButton;
        private MaterialSkin.Controls.MaterialButton startButton;
        private System.Windows.Forms.TextBox sampleText;
    }
}

