using System;
using Android.Content;
using Android.Provider;

namespace Xam.Plugin.DeviceSettings.Droid
{
	public class DeviceSettingsService : IDeviceSettings
	{
		Context _context;
		public DeviceSettingsService (Context context)
		{
			_context = context;
		}

		#region IDeviceSettings implementation

		public void OpenWifiSettings ()
		{
			_context.StartActivity (new Intent (Settings.ActionWifiSettings));
		}

		#endregion
	}
}

