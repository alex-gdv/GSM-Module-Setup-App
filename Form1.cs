using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GSM_Module_Setup_App
{
    public partial class SetupMenu : System.Windows.Forms.Form
    {
        // Important commands:
        // AT+CFUN=1 full functionality
        // AT+CPOF save data and power off
        // AT+CRESET reset module
        // AT+CUSBPIDSWITCH=9003,1,1 setup

        private IDictionary<string, string> acTNumberToNameDict = new Dictionary<string, string>()
        {
            {"0", "GSM"},
            {"1", "GSM Compact"},
            {"2", "UTRAN"},
            {"7", "EUTRAN"},
            {"8", "CDMA/HDR"}
        };
        private IDictionary<string, string> actNameToNumberDict = new Dictionary<string, string>()
        {
            {"GSM", "0"},
            {"GSM Compact", "1"},
            {"UTRAN", "2"},
            {"EUTRAN", "7"},
            {"CDMA/HDR", "8"}
        };
        private string receiveBuffer;
        private bool reportGPSNMEAEnabled;

        public SetupMenu()
        {
            Application.EnableVisualStyles();
            receiveBuffer = "";
            reportGPSNMEAEnabled = false;
            InitializeComponent();
            comboBoxBaudRate.SelectedIndex = 1;
            buttonClosePort.Enabled = false;
        }

        private void SetupMenu_Load(object sender, EventArgs e)
        {
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(portName);
            }
        }

        private void SetupMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            receiveBuffer = serialPort.ReadExisting();
            try
            {
                this.Invoke(new EventHandler(displayText));
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayText(object sender, EventArgs e)
        {
            /*            int buffPos;
                        if ((buffPos = receiveBuffer.IndexOf("\r\n")) >= 0)
                        {
                            richTextBoxReceivedData.AppendText(receiveBuffer.Substring(buffPos + 2, receiveBuffer.LastIndexOf("\r\n") - buffPos - 2) + "\n\n");
                        }
                        else
                        {
                            richTextBoxReceivedData.AppendText(receiveBuffer + "\n");
                        }*/
            richTextBoxReceivedData.AppendText(receiveBuffer + "\n");
        }

        private void writeCommandToPort(string command)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(command + "\r");
            }
        }

        private void getSignalQuality()
        {
            writeCommandToPort("AT+CSQ");
            System.Threading.Thread.Sleep(1000);
            string signalStrength;
            string temp1 = receiveBuffer.Substring(receiveBuffer.IndexOf("+CSQ: ") + 6);
            int temp2 = Int32.Parse(temp1.Substring(0, temp1.IndexOf(",")));
            if (temp2 == 0 || temp2 == 1)
            {
                signalStrength = "Poor";
            }
            else if (temp2 >= 2 && temp2 <= 9)
            {
                signalStrength = "Marginal";
            }
            else if (temp2 >= 10 && temp2 <= 14)
            {
                signalStrength = "OK";
            }
            else if (temp2 >= 15 && temp2 <= 19)
            {
                signalStrength = "Good";
            }
            else if (temp2 >= 20 && temp2 <= 30)
            {
                signalStrength = "Very good";
            }
            else if (temp2 == 31)
            {
                signalStrength = "Excellent";
            }
            else
            {
                signalStrength = "Unknown";
            }
            toolStripStatusLabelSignalStrength.Text = "Signal strength: " + signalStrength;
        }

        private void initialSetup()
        {
            getSignalQuality();
            // Start GPS
            writeCommandToPort("AT+CGPS=1");
            // Start GPS automatically when module powers on
            writeCommandToPort("AT+CGPSAUTO=1");
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    // Open port
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());
                    serialPort.Open();
                    // Initial setup
                    initialSetup();
                    // Update interface
                    comboBoxPorts.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    buttonOpenPort.Enabled = false;
                    buttonClosePort.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    // Close port
                    serialPort.Close();
                    // Update interface
                    buttonClosePort.Enabled = false;
                    buttonOpenPort.Enabled = true;
                    comboBoxPorts.Enabled = true;
                    comboBoxBaudRate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectProvider(string provider, string acT = "")
        {
            writeCommandToPort("AT+COPS=2");
            if (acT != "")
            {
                writeCommandToPort("AT+COPS=1,0," + provider + "," + acT);
                if (receiveBuffer.Contains("SIM DONE"))
                {
                    labelCurrentProvider.Text = "Current Provider: " + provider + " (" + acT + ")";
                }
            }
            else
            {
                writeCommandToPort("AT+COPS=1,0," + provider);
                if (receiveBuffer.Contains("SIM DONE"))
                {
                    labelCurrentProvider.Text = "Current Provider: " + provider;
                }
            }
        }

        private void buttonSelectProvider_Click(object sender, EventArgs e)
        {
            string temp = comboBoxProviders.SelectedItem.ToString();
            string provider = temp.Substring(0, temp.LastIndexOf("\"")+1);
            string acT = temp.Substring(temp.LastIndexOf("\"") + 3, temp.Length - temp.LastIndexOf("\"") - 3 - 1);
            if (acT != "Unknown")
            {
                selectProvider(provider, actNameToNumberDict[acT]);
            }
            else
            {
                selectProvider(provider);
            }
        }

        private List<string> getProviders()
        {
            writeCommandToPort("AT+COPS=?");
            MessageBox.Show("Detecting available network operators... Please wait until the response is displayed in the Received Data box before clicking OK. Depending on network conditions, wait times may vary. While detecting available operators, any input from the serial port will stop this process.");
            List<string> providers = new List<string>();
            string temp1 = receiveBuffer.Substring(receiveBuffer.IndexOf("+COPS: ") + 7);
            temp1 = temp1.Substring(0, temp1.IndexOf(",,"));
            string[] tempArr1 = temp1.Split(new string[] { ")," }, System.StringSplitOptions.None);
            foreach (string s in tempArr1)
            {
                string[] tempArr2 = s.Split(',');
                string tempAcT = "Unknown";
                if (acTNumberToNameDict.ContainsKey(tempArr2[4]))
                {
                    tempAcT = acTNumberToNameDict[tempArr2[4]];
                }
                if (tempArr2[0] == "(2")
                {
                    labelCurrentProvider.Text = "Current provider: " + tempArr2[1] + " (" + tempAcT + ")";
                    continue;
                }
                providers.Add(tempArr2[1] + " (" + tempAcT + ")");
            }
            return providers;
        }

        private void buttonGetProviders_Click(object sender, EventArgs e)
        {
            List<string> providers = getProviders();
            foreach (string provider in providers)
            {
                comboBoxProviders.Items.Add(provider);
            }
        }

        private void buttonEnterPIN_Click(object sender, EventArgs e)
        {
            serialPort.Write("AT+CPIN?\r");
        }

        private void buttonReportGPSNMEA_Click(object sender, EventArgs e)
        {
            if (!reportGPSNMEAEnabled)
            {
                // 65664 for GNGSA and BDGSA/PQGSA
                writeCommandToPort("AT+CGPSINFOCFG=30,65664");
                reportGPSNMEAEnabled = true;
                buttonReportGPSNMEA.Text = "Stop";
                // Start timer to update table
            }
            else
            {
                writeCommandToPort("AT+CGPSINFOCFG=0");
                reportGPSNMEAEnabled = false;
                buttonReportGPSNMEA.Text = "Start";
                // Stop timer
            }
        }
    }
}
