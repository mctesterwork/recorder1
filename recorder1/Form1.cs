using Microsoft.VisualBasic.ApplicationServices;
using ScreenRecorderLib;
using System.Reflection;
using System.Windows.Forms;

namespace recorder1
{
    public partial class Form1 : Form
    {
        IRecorder _recorder = new IRecorder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            // Settings for the recording paramters
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string filePath = Path.Combine(Path.GetTempPath(), "TinyScreenRecorder", timestamp, timestamp + ".mp4");
            int quality = 80;

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
                _recorder.Settings(filePath);
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
            Dictionary<string, string> inputDevices = _recorder.GetAudioIns();
            this.cbox_inputDevices.Items.AddRange(inputDevices.Keys.ToArray());
            this.cbox_inputDevices.SelectedIndex = 0;
        }

        private void LoadOutputDevices()
        {
            Dictionary<string, string> outputDevices = _recorder.GetAudioOuts();
            this.cbox_outputDevices.Items.AddRange(outputDevices.Keys.ToArray());
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
    }
}