using Microsoft.VisualBasic.ApplicationServices;
using ScreenRecorderLib;
using System.Reflection;
using System.Windows.Forms;

namespace recorder1
{
    public partial class Form1 : Form
    {
        IRecorder _recorder = new IRecorder();
        string selectedPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            // Settings for the recording paramters
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "TinyScreenRecorder", timestamp, timestamp + ".mp4");
            if (Directory.Exists(selectedPath))
            {
                filePath = Path.Combine(selectedPath, "TinyScreenRecorder", timestamp, timestamp + ".mp4");
            }
            int quality = tbar_Quality.Value * 10;
            bool audioInEnabled = chbox_Input.Checked;
            bool audioOutEnabled = chbox_Output.Checked;
            int selectedInputIndex = cbox_inputDevices.SelectedIndex;
            int selectedOutputIndex = cbox_outputDevices.SelectedIndex;
            string selectedAudioInput = cbox_inputDevices.Items.Count > 0 ? Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices)[selectedInputIndex].DeviceName : "";
            string selectedAudioOutput = cbox_outputDevices.Items.Count > 0 ? Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices)[selectedOutputIndex].DeviceName : "";
            bool showingClicks = chbox_ShowClicks.Checked;
            bool showingPointer = true;


            // Start / Stop the recording and button toggle
            if (_recorder.RecordingStatus()) 
            {
                this.btn_Record.Enabled = false;
                _recorder.Stop();
                this.btn_Record.Text = "RECORD";
                this.btn_Record.Enabled = true;
            }
            else 
            {
                this.btn_Record.Enabled = false;
                _recorder.Settings(filePath, quality, showingClicks, showingPointer, audioInEnabled, audioOutEnabled,
                    selectedAudioInput, selectedAudioOutput);
                _recorder.Start();
                this.btn_Record.Text = "STOP";
                this.btn_Record.Enabled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the comboboxes with available device names
            LoadInputDevices();
            LoadOutputDevices();
        }

        private void LoadInputDevices()
        {
            List<string> inputDevicesList = _recorder.GetAudioIns();
            this.cbox_inputDevices.Items.AddRange(inputDevicesList.ToArray());
            this.cbox_inputDevices.SelectedIndex = 0;
        }

        private void LoadOutputDevices()
        {
            List<string> outputDevicesList = _recorder.GetAudioOuts();
            this.cbox_outputDevices.Items.AddRange(outputDevicesList.ToArray());
            this.cbox_outputDevices.SelectedIndex = 0;
        }

        // This code is for displaying in tray icon when minimized. TODO: Trigger this when recording starts
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000);
            }
        }
        // This code is for restoring the window from the tray. TODO: Trigger this when recording stops
        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState= FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;
                label_SelectedPath.Text = selectedPath;
            }
        }
    }
}