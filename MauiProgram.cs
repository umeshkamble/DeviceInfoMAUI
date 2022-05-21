using DeviceInfoMAUI.Services;

namespace DeviceInfoMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddSingleton<IDeviceInformation, DeviceInformation>();
		return builder.Build();
	}
}
