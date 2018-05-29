using System.Diagnostics;
using System.IO;
using AVFoundation;
using Foundation;
using SimpleAudioForms.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]

namespace SimpleAudioForms.iOS
{
    public class AudioService : IAudio
    {
        private AVAudioPlayer audioPlayer;

        public AudioService() { }

        private bool Play(string fileName, string fileTypeHint)
        {
            var filePath = NSBundle.MainBundle.PathForResource(Path.GetFileNameWithoutExtension(fileName),
                                                               Path.GetExtension(fileName));
            Debug.Assert(!string.IsNullOrEmpty(filePath));
            var url = NSUrl.FromString(filePath);

            NSError outError;
            NSUrl fileURL = new NSUrl(fileName);
            audioPlayer = new AVAudioPlayer(url: fileURL, fileTypeHint: fileTypeHint, outError: out outError);
            audioPlayer.FinishedPlaying += (object sender, AVStatusEventArgs e) => audioPlayer = null;
            audioPlayer.Play();

            return null == outError;
        }

        #region IAudio
        public bool PlayMp3File(string fileName)
        {
            Debug.WriteLine($"PlayMp3File(string {fileName})");
            return Play(fileName, AVFileType.MpegLayer3);
        }

        public bool PlayWavFile(string fileName)
        {
            Debug.WriteLine($"PlayWavFile(string {fileName})");
            return Play(fileName, AVFileType.Wave);
        }
        #endregion IAudio
    }
}
