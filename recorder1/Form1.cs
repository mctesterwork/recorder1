using ScreenRecorderLib;
using System.Windows.Forms;

namespace recorder1
{
    public partial class Form1 : Form
    {
        // IRecorder __recorder = new IRecorder();
        private bool isRecording = false;
        private Recorder _rec = Recorder.CreateRecorder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            if (isRecording == false)
            {
                startRecording();
            }
            else { 
                stopRecording();
            }
        }

        private void cbox_inputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getInputDevices();
            getOutputDevices();
        }

        private void getInputDevices()
        {
            // Here we should do the process of getting input devices, we also need a setter function and to return the list
            var inputDevices = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices);
            foreach (var device in inputDevices)
            {
                cbox_inputDevices.Items.Add(device.FriendlyName);
            }
            // Set default input
            this.cbox_inputDevices.SelectedIndex = 0;
        }

        private void getOutputDevices()
        {
            // Here we should do the process of getting output devices, we also need a setter function and to return the list
            var outputDevices = Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices);
            foreach(var device in outputDevices)
            {
                cbox_outputDevices.Items.Add(device.FriendlyName);
            }
            // Set default output
            this.cbox_outputDevices.SelectedIndex = 0;
        }

        private void cbox_outputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Start recording function
        private void startRecording()
        {
            // First we need to set the recorder options
            this.btn_Record.Enabled = false;
            var opts = new RecorderOptions
            {
                AudioOptions = new AudioOptions
                {
                    AudioInputDevice = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices).First().DeviceName,
                    AudioOutputDevice = null,
                    IsAudioEnabled = true,
                    IsInputDeviceEnabled = true,
                    IsOutputDeviceEnabled = false,
                },
                VideoEncoderOptions = new VideoEncoderOptions
                {
                    Quality = 80
                }
            };
            _rec.SetOptions(opts);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string filePath = Path.Combine(Path.GetTempPath(), "ScreenRecorder", timestamp, timestamp + ".mp4");
            _rec.Record(filePath);
            isRecording = true;
            this.btn_Record.Text = "STOP";
            this.btn_Record.Enabled = true;

        }
        private void stopRecording()
        {
            this.btn_Record.Enabled = false;
            _rec.Stop();
            this.btn_Record.Text = "RECORD";
            this.btn_Record.Enabled = true;
            isRecording = false;
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