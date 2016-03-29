using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xam.Plugin.DeviceSettings;
using Xam.Plugin.DeviceSettings.Droid;

namespace DeviceSettings.Droid
{
	[Activity (Label = "DeviceSettings.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			Splat.Locator.CurrentMutable.Register (
				() => new DeviceSettingsService(this),
				typeof(IDeviceSettings)
			);

			LoadApplication (new App ());
		}
	}
}

