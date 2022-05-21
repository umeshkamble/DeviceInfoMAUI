using System;
namespace DeviceInfoMAUI.Services
{
	public interface IDeviceInformation
	{
		string GetAppVersion();
		string GetApplicationBuildNumber();
		string GetPackageName();
	}
}

