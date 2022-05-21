using DeviceInfoMAUI.Services;

namespace DeviceInfoMAUI;

public partial class MainPage : ContentPage
{
	
	IDeviceInformation deviceInfo;
    public MainPage(IDeviceInformation deviceInformation)
    {
		InitializeComponent();
		deviceInfo = deviceInformation;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Information", $"Package Name:\n {deviceInfo.GetPackageName()} \n \n Build Number: \n {deviceInfo.GetAppVersion()}_build_{deviceInfo.GetApplicationBuildNumber()} ", "OK");
	}
}

