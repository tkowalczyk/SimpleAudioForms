using System;
using Xamarin.Forms;
using SimpleAudioForms.Droid;
using Android.Media;

[assembly: Dependency(typeof(AudioService))]

namespace SimpleAudioForms.Droid
{
	public class AudioService : IAudio
	{
		public AudioService() {}

		private MediaPlayer _mediaPlayer;

		public bool PlayMp3File(string fileName)
		{
			_mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test);
			_mediaPlayer.Start();

			return true;
		}

		public bool PlayWavFile(string fileName)
		{
			_mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.ding_persevy);
			_mediaPlayer.Start();

			return true;
		}
	}
}