
namespace GSM_Module_Setup_App
{
    partial class SetupMenu
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.richTextBoxReceivedData = new System.Windows.Forms.RichTextBox();
            this.groupBoxReceivedData = new System.Windows.Forms.GroupBox();
            this.groupBoxPortSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.buttonGetProviders = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxProviderSettings = new System.Windows.Forms.GroupBox();
            this.labelCurrentProvider = new System.Windows.Forms.Label();
            this.buttonSelectProvider = new System.Windows.Forms.Button();
            this.comboBoxProviders = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSignalStrength = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxPINSettings = new System.Windows.Forms.GroupBox();
            this.buttonEnterPIN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new GSM_Module_Setup_App.BufferedListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReportGPSNMEA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxReceivedData.SuspendLayout();
            this.groupBoxPortSettings.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxProviderSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxPINSettings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(6, 68);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // richTextBoxReceivedData
            // 
            this.richTextBoxReceivedData.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxReceivedData.Name = "richTextBoxReceivedData";
            this.richTextBoxReceivedData.Size = new System.Drawing.Size(488, 273);
            this.richTextBoxReceivedData.TabIndex = 3;
            this.richTextBoxReceivedData.Text = "";
            // 
            // groupBoxReceivedData
            // 
            this.groupBoxReceivedData.Controls.Add(this.richTextBoxReceivedData);
            this.groupBoxReceivedData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxReceivedData.Name = "groupBoxReceivedData";
            this.groupBoxReceivedData.Size = new System.Drawing.Size(500, 300);
            this.groupBoxReceivedData.TabIndex = 4;
            this.groupBoxReceivedData.TabStop = false;
            this.groupBoxReceivedData.Text = "Received Data";
            // 
            // groupBoxPortSettings
            // 
            this.groupBoxPortSettings.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxPortSettings.Controls.Add(this.label3);
            this.groupBoxPortSettings.Controls.Add(this.label2);
            this.groupBoxPortSettings.Controls.Add(this.comboBoxPorts);
            this.groupBoxPortSettings.Controls.Add(this.buttonClosePort);
            this.groupBoxPortSettings.Controls.Add(this.buttonOpenPort);
            this.groupBoxPortSettings.Location = new System.Drawing.Point(516, 6);
            this.groupBoxPortSettings.Name = "groupBoxPortSettings";
            this.groupBoxPortSettings.Size = new System.Drawing.Size(252, 96);
            this.groupBoxPortSettings.TabIndex = 5;
            this.groupBoxPortSettings.TabStop = false;
            this.groupBoxPortSettings.Text = "Port Settings";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(112, 38);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(100, 24);
            this.comboBoxBaudRate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(6, 38);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(100, 24);
            this.comboBoxPorts.TabIndex = 3;
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.Location = new System.Drawing.Point(112, 68);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(100, 23);
            this.buttonClosePort.TabIndex = 2;
            this.buttonClosePort.Text = "Close";
            this.buttonClosePort.UseVisualStyleBackColor = true;
            this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // buttonGetProviders
            // 
            this.buttonGetProviders.Location = new System.Drawing.Point(6, 47);
            this.buttonGetProviders.Name = "buttonGetProviders";
            this.buttonGetProviders.Size = new System.Drawing.Size(75, 23);
            this.buttonGetProviders.TabIndex = 6;
            this.buttonGetProviders.Text = "Search";
            this.buttonGetProviders.UseVisualStyleBackColor = true;
            this.buttonGetProviders.Click += new System.EventHandler(this.buttonGetProviders_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(782, 653);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxProviderSettings);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.groupBoxPINSettings);
            this.tabPage1.Controls.Add(this.groupBoxReceivedData);
            this.tabPage1.Controls.Add(this.groupBoxPortSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxProviderSettings
            // 
            this.groupBoxProviderSettings.Controls.Add(this.labelCurrentProvider);
            this.groupBoxProviderSettings.Controls.Add(this.buttonSelectProvider);
            this.groupBoxProviderSettings.Controls.Add(this.comboBoxProviders);
            this.groupBoxProviderSettings.Controls.Add(this.buttonGetProviders);
            this.groupBoxProviderSettings.Location = new System.Drawing.Point(6, 312);
            this.groupBoxProviderSettings.Name = "groupBoxProviderSettings";
            this.groupBoxProviderSettings.Size = new System.Drawing.Size(500, 147);
            this.groupBoxProviderSettings.TabIndex = 9;
            this.groupBoxProviderSettings.TabStop = false;
            this.groupBoxProviderSettings.Text = "Provider Settings";
            // 
            // labelCurrentProvider
            // 
            this.labelCurrentProvider.AutoSize = true;
            this.labelCurrentProvider.Location = new System.Drawing.Point(228, 90);
            this.labelCurrentProvider.Name = "labelCurrentProvider";
            this.labelCurrentProvider.Size = new System.Drawing.Size(115, 17);
            this.labelCurrentProvider.TabIndex = 9;
            this.labelCurrentProvider.Text = "Current provider:";
            // 
            // buttonSelectProvider
            // 
            this.buttonSelectProvider.Location = new System.Drawing.Point(309, 46);
            this.buttonSelectProvider.Name = "buttonSelectProvider";
            this.buttonSelectProvider.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectProvider.TabIndex = 8;
            this.buttonSelectProvider.Text = "Select";
            this.buttonSelectProvider.UseVisualStyleBackColor = true;
            this.buttonSelectProvider.Click += new System.EventHandler(this.buttonSelectProvider_Click);
            // 
            // comboBoxProviders
            // 
            this.comboBoxProviders.FormattingEnabled = true;
            this.comboBoxProviders.Location = new System.Drawing.Point(139, 46);
            this.comboBoxProviders.Name = "comboBoxProviders";
            this.comboBoxProviders.Size = new System.Drawing.Size(157, 24);
            this.comboBoxProviders.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSignalStrength});
            this.statusStrip1.Location = new System.Drawing.Point(3, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSignalStrength
            // 
            this.toolStripStatusLabelSignalStrength.Name = "toolStripStatusLabelSignalStrength";
            this.toolStripStatusLabelSignalStrength.Size = new System.Drawing.Size(121, 20);
            this.toolStripStatusLabelSignalStrength.Text = "Signal strength: -";
            // 
            // groupBoxPINSettings
            // 
            this.groupBoxPINSettings.Controls.Add(this.textBox2);
            this.groupBoxPINSettings.Controls.Add(this.button2);
            this.groupBoxPINSettings.Controls.Add(this.button1);
            this.groupBoxPINSettings.Controls.Add(this.buttonEnterPIN);
            this.groupBoxPINSettings.Controls.Add(this.textBox1);
            this.groupBoxPINSettings.Location = new System.Drawing.Point(516, 108);
            this.groupBoxPINSettings.Name = "groupBoxPINSettings";
            this.groupBoxPINSettings.Size = new System.Drawing.Size(252, 145);
            this.groupBoxPINSettings.TabIndex = 7;
            this.groupBoxPINSettings.TabStop = false;
            this.groupBoxPINSettings.Text = "Enter PIN";
            // 
            // buttonEnterPIN
            // 
            this.buttonEnterPIN.Location = new System.Drawing.Point(112, 21);
            this.buttonEnterPIN.Name = "buttonEnterPIN";
            this.buttonEnterPIN.Size = new System.Drawing.Size(100, 23);
            this.buttonEnterPIN.TabIndex = 1;
            this.buttonEnterPIN.Text = "Enter";
            this.buttonEnterPIN.UseVisualStyleBackColor = true;
            this.buttonEnterPIN.Click += new System.EventHandler(this.buttonEnterPIN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.buttonReportGPSNMEA);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GPS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 612);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GNSS";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 175;
            // 
            // buttonReportGPSNMEA
            // 
            this.buttonReportGPSNMEA.Location = new System.Drawing.Point(627, 125);
            this.buttonReportGPSNMEA.Name = "buttonReportGPSNMEA";
            this.buttonReportGPSNMEA.Size = new System.Drawing.Size(75, 23);
            this.buttonReportGPSNMEA.TabIndex = 0;
            this.buttonReportGPSNMEA.Text = "Start";
            this.buttonReportGPSNMEA.UseVisualStyleBackColor = true;
            this.buttonReportGPSNMEA.Click += new System.EventHandler(this.buttonReportGPSNMEA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change PIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Request";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PDOP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "HDOP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "VDOP:";
            // 
            // SetupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.tabControl);
            this.Name = "SetupMenu";
            this.Text = "GSM Module Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetupMenu_FormClosed);
            this.Load += new System.EventHandler(this.SetupMenu_Load);
            this.groupBoxReceivedData.ResumeLayout(false);
            this.groupBoxPortSettings.ResumeLayout(false);
            this.groupBoxPortSettings.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxProviderSettings.ResumeLayout(false);
            this.groupBoxProviderSettings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxPINSettings.ResumeLayout(false);
            this.groupBoxPINSettings.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.RichTextBox richTextBoxReceivedData;
        private System.Windows.Forms.GroupBox groupBoxReceivedData;
        private System.Windows.Forms.GroupBox groupBoxPortSettings;
        private System.Windows.Forms.Button buttonClosePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGetProviders;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxPINSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEnterPIN;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSignalStrength;
        private System.Windows.Forms.GroupBox groupBoxProviderSettings;
        private System.Windows.Forms.Button buttonSelectProvider;
        private System.Windows.Forms.ComboBox comboBoxProviders;
        private System.Windows.Forms.Label labelCurrentProvider;
        private System.Windows.Forms.Button buttonReportGPSNMEA;
        private BufferedListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

