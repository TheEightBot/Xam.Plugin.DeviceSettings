using System;
using UIKit;

namespace Xam.Plugin.DeviceSettings.iOS
{
	public class DeviceSettingsService : IDeviceSettings
	{
		public DeviceSettingsService ()
		{
		}

		#region IDeviceSettings implementation

		public void OpenWifiSettings ()
		{
			TooBadThisIsYourOnlyOption ();
		}

		#endregion

		void TooBadThisIsYourOnlyOption(){
			var url = Foundation.NSUrl.FromString (UIApplication.OpenSettingsUrlString);

			if(UIApplication.SharedApplication.CanOpenUrl(url))
				UIApplication.SharedApplication.OpenUrl (url);
		}
	}

}

