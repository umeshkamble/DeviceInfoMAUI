using System;
#if __IOS__
 using Foundation;
#elif __ANDROID__
using Android.Content.PM;
#endif
namespace DeviceInfoMAUI.Services
{
    public class DeviceInformation : IDeviceInformation
    {
        public DeviceInformation()
        {
        }
        public string GetAppVersion()
        {
#if __IOS__
 return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
#elif __ANDROID__
            using (var info = Android.App.Application.Context.PackageManager.GetPackageInfo(Android.App.Application.Context.PackageName, PackageInfoFlags.MetaData))
                return info.VersionName;
#endif
            return "";
        }
        public string GetApplicationBuildNumber()
        {
#if __IOS__

            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
#elif __ANDROID__
            var context = global::Android.App.Application.Context;
            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);

            return info.VersionCode.ToString();
#endif

            return "";
        }
        public string GetPackageName()
        {
#if __IOS__

            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleIdentifier").ToString();
#elif __ANDROID__
            var context = Android.App.Application.Context;
            return context.PackageName;
#endif
            return "";
        }
    }
}

