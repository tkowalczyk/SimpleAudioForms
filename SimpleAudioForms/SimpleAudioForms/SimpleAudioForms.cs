using System;

using Xamarin.Forms;

namespace SimpleAudioForms
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Button {
							Text = "Play *.wav file!",
							Command = new Command(() =>
								{
									DependencyService.Get<IAudio>().PlayWavFile(
										"ding_persevy.wav"
									);
								})
						},
						new Button {
							Text = "Play *.mp3 file!",
							Command = new Command(() =>
								{
									DependencyService.Get<IAudio>().PlayMp3File(
										"test.mp3"
									);
								})
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

