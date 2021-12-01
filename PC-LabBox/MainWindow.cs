using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_LabBox
{
    public partial class MainWindow : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    "\\PC_LabBox";
        private string mngEmailPath = " ";
        private string mngAuthorizedEmailsPath = " ";

       
        private SerialPort USBport;
        private string in_data;
        private int timeSample = 1; // 1 second
        

        public MainWindow()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            mngEmailPath = mainPath + "\\mananingEmail.txt";
            mngAuthorizedEmailsPath = mainPath + "\\AuthoriezedEmails.txt";
            stopButton.Enabled = false;
            customPanel.Enabled = false;
            DisconnectSerialButton.Enabled = false;
            Thread thread1 = new Thread(ReadEmailThread);
            thread1.Start();
        }


        

        private void startButton_Click(object sender, EventArgs e)
        {
            
            SerialMonitor.Clear();

            try
            {
                
                if (USBport.IsOpen)
                {
                    USBport.WriteLine("1");
                    //USBport.WriteLine(timeSample.ToString());
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please connect the LabBox device first!\nError: "+ex.Message, "Serial connection error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sampleTimeBar.Enabled = false;
            startButton.Enabled = false;
            stopButton.Enabled = true;

        }
       

        private void MainWindow_Load(object sender, EventArgs e)
        {
            

        }

        private void authorizedEmailsButton_Click(object sender, EventArgs e)
        {
            if (authorizedEmailsPanel.Visible)
            {
                authorizedEmailsPanel.Visible = false;
                return;
            }
            else
            {
                serialConnectionPanel.Visible = false;
                managingEmailPanel.Visible = false;
                authorizedEmailsPanel.Visible = true;
                if (!File.Exists(mngAuthorizedEmailsPath))
                {
                    return;
                }
                string[] emails = System.IO.File.ReadAllLines(mngAuthorizedEmailsPath);
                emailListBox.Items.Clear();
                foreach (var line in emails)
                {
                    emailListBox.Items.Add(line);
                }
                
                
            }
        }

        private void managingEmailButton_Click(object sender, EventArgs e)
        {
            if (managingEmailPanel.Visible)
            {
                managingEmailPanel.Visible = false;
                return;
            }
            else
            {
                serialConnectionPanel.Visible = false;
                authorizedEmailsPanel.Visible = false;
                managingEmailPanel.Visible = true;
                CheckManagingEmail();
                
            }
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(mainPath))
            {
            DirectoryInfo di = Directory.CreateDirectory(mainPath);
            }
            if (!File.Exists(mngEmailPath))
            {
                WriteTextFile(mngEmailPath);
                return;
            }
            File.Delete(mngEmailPath);
            WriteTextFile(mngEmailPath);
        }

        private void WriteTextFile(string filePath)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(emailField.Text);
                sw.WriteLine(passwordField.Text);
            }

        }

        private void CheckManagingEmail()
        {
            if (!File.Exists(mngEmailPath))
            {
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(mngEmailPath);
            emailField.Text = lines[0]; 
            passwordField.Text = lines[1]; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void serialConnectionButton_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            serialPortBox.Items.Clear();
            serialPortBox.Items.AddRange(ports);

            if (serialConnectionPanel.Visible)
            {
                serialConnectionPanel.Visible = false;
                
                return;
            }
            else
            {
                serialConnectionPanel.Visible = true;
                authorizedEmailsPanel.Visible = false;
                managingEmailPanel.Visible = false;
                
            }
        }
        
        private void serialPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ConnectSerialButton_Click(object sender, EventArgs e)
        {
            try
            {
                USBport = new SerialPort(serialPortBox.SelectedItem.ToString(), Int32.Parse(serialSpeedBox.SelectedItem.ToString()));
                USBport.Parity = Parity.None;
                USBport.StopBits = StopBits.One;
                USBport.Handshake = Handshake.RequestToSend;
                USBport.DataBits = 8;
                USBport.Open();
                USBport.DataReceived += new SerialDataReceivedEventHandler(mySerialPort_DataReceived);

            }
            catch (Exception ex) {
                MessageBox.Show("Serial port or baudrate not selected\nError: "+ex.Message, "Serial connection error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConnectSerialButton.Enabled = false;
            DisconnectSerialButton.Enabled = true;
            serialPortBox.Enabled = false;
            serialSpeedBox.Enabled = false;
        }
        public void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
            in_data = USBport.ReadExisting();
            this.Invoke((Delegate) new EventHandler(displaydata_event));
            Console.WriteLine(in_data);
            }
            catch (Exception)
            {
                MessageBox.Show("Error to read seral data!");
            }
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            SerialMonitor.AppendText(in_data);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            
            try {
                if (USBport.IsOpen) {
                    USBport.WriteLine("2");
                }            
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sampleTimeBar.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;


        }

        private void DisconnectSerialButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                USBport.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConnectSerialButton.Enabled = true;
            DisconnectSerialButton.Enabled = false;
            serialPortBox.Enabled = true;
            serialSpeedBox.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void serialSpeedBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SerialMonitor_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newEmail = addEmailTextBox.Text.ToString();
            addEmailTextBox.Clear();
            emailListBox.Items.Add(newEmail);
            
        }

        private void materialButton1_Click(object sender, EventArgs e)// save button
        {
            if (!Directory.Exists(mainPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(mainPath);
            }
            if (!File.Exists(mngAuthorizedEmailsPath))
            {
                WriteTextFile(mngAuthorizedEmailsPath);
                return;
            }
            File.Delete(mngAuthorizedEmailsPath);
            WriteTextFile(mngAuthorizedEmailsPath);
            using (StreamWriter sw = File.CreateText(mngAuthorizedEmailsPath))
            {
               
                foreach (var item in emailListBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void inputSerialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioDefaultSettings_CheckedChanged(object sender, EventArgs e)
        {
            customPanel.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            customPanel.Enabled = true;
        }

        private void startCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (startCommand.Checked)
            {
                startCondition.Enabled = true;
            }
            else {
                startCondition.Enabled = false;
            }
        }

        private void stopCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (stopCommand.Checked)
            {
                stopCondition.Enabled = true;
            }
            else
            {
                stopCondition.Enabled = false;
            }
        }

        private void sampleTimeBar_Scroll(object sender, EventArgs e)
        {
            timeSample = sampleTimeBar.Value;
            sampleText.Clear();
            sampleText.AppendText(timeSample.ToString() + "s");
        }

        private void homeTab_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Force shut down
            int i = 0;
            

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            
            



        }


        private void ReadEmailThread() {

            while (true)
            {

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(i);
                }
            }
        
        
        }

        private void emailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
