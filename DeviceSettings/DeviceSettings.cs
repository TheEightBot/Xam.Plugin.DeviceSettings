using System;

using Xamarin.Forms;
using Splat;
using Xam.Plugin.DeviceSettings;

namespace DeviceSettings
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
							Text = "Open WIFI",
							Command = new Command(_ =>{
								var deviceSettings = Locator.CurrentMutable.GetService<IDeviceSettings> ();
								deviceSettings.OpenWifiSettings();
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

