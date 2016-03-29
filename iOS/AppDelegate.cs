using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xam.Plugin.DeviceSettings;
using Xam.Plugin.DeviceSettings.iOS;

namespace DeviceSettings.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			Splat.Locator.CurrentMutable.Register (
				() => new DeviceSettingsService(),
				typeof(IDeviceSettings)
			);

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

