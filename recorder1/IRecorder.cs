using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenRecorderLib;
using System.Windows.Forms;


// This class is supposed to contain all the recording features, abstracted from the Windows Form code

namespace recorder1
{
    internal class IRecorder
    {
        bool isRecording = false;
        bool showClicks = false;
        bool showPointer = false;
        bool recordAudioInput = true;
        bool recordAudioOutput = false;
        string AudioInName = string.Empty;
        string AudioOutName = string.Empty;
        string path = string.Empty;
        int quality = 70;
        Recorder rec;
        public void Start()
        {
            if (isRecording)
            {
                this.rec.Stop();
                return;
            }
            if (rec == null)
            {
                this.rec = Recorder.CreateRecorder();
                this.rec.OnRecordingComplete += Rec_OnRecordingComplete;
                this.rec.OnRecordingFailed += Rec_OnRecordingFailed;
            }

            var opts = new RecorderOptions
            {
                AudioOptions = new AudioOptions
                {
                    IsInputDeviceEnabled = this.recordAudioInput,
                    IsOutputDeviceEnabled = this.recordAudioOutput,
                    AudioInputDevice = this.AudioInName,
                    AudioOutputDevice = this.AudioOutName
                },
                VideoEncoderOptions = new VideoEncoderOptions
                {
                    Quality = this.quality
                },
                MouseOptions = new MouseOptions
                {
                    IsMouseClicksDetected = this.showClicks,
                    IsMousePointerEnabled = this.showPointer
                }
            };

            this.rec.SetOptions(opts);

            // Here goes the code to start recording, validate path before using it
            this.rec.Record(this.path);
            this.isRecording= true;
        }

        private void Rec_OnRecordingFailed(object? sender, RecordingFailedEventArgs e)
        {
            this.isRecording = false;
            CleanupResources();
        }

        private void Rec_OnRecordingComplete(object? sender, RecordingCompleteEventArgs e)
        {
            this.isRecording = false;
        }

        public void Stop() {
            // Here goes the code to stop existing recording
            if (isRecording)
            {
                this.rec.Stop();
            }
        }
        public void Settings(string _path, int _quality=70, bool _showClicks=false, bool _showPointer=true, bool _recordAudioInput=false, bool _recordAudioOutput=false, string _inputDeviceName="", string _outputDeviceName="")
        {
            // Here I shuld adjust settings before recording
            this.path = _path; // Path if valid path is indicated, otherwise temp directory
            if (_quality < 100) { this.quality = _quality; }
            this.showClicks = _showClicks;
            this.showPointer = _showPointer;
            this.recordAudioInput = _recordAudioInput;
            this.recordAudioOutput = _recordAudioOutput;
            this.AudioInName = _inputDeviceName;
            this.AudioOutName = _outputDeviceName;

        }
        public bool RecordingStatus()
        {
            return this.isRecording;
        }

        private void CleanupResources()
        {
            this.rec?.Dispose();
            this.rec = null;
        }

        public Dictionary<string, string> GetAudioIns()
        {
            Dictionary<string, string> inputDevicesList = new Dictionary<string, string>();
            var devices = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices);
            foreach (var device in devices)
            {
                inputDevicesList.Add(device.FriendlyName, device.DeviceName);
            }
            return inputDevicesList;
        }

        public Dictionary<string, string> GetAudioOuts ()
        {
            Dictionary<string, string> outputDevicesList = new Dictionary<string, string>();
            var devices = Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices);
            foreach (var device in devices)
            {
                outputDevicesList.Add(device.FriendlyName, device.DeviceName);
            }
            return outputDevicesList;
        }

    }
}
