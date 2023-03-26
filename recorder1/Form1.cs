namespace recorder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            var inputDevices = ScreenRecorderLib.Recorder.GetSystemAudioDevices(ScreenRecorderLib.AudioDeviceSource.InputDevices);
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
            var outputDevices = ScreenRecorderLib.Recorder.GetSystemAudioDevices(ScreenRecorderLib.AudioDeviceSource.OutputDevices);
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
    }
}