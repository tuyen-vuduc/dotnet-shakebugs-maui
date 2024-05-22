using Microsoft.Extensions.Logging;
using ShakeBugs;

namespace ShakeMauiQs;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseShakeBugs(
				androidId: "YOUR_ANDROID_ID",
				androidSecret: "YOUR_ANDROID_SECRETE",
				iosId: "YOUR_IOS_ID",
				iosSecret: "YOUR_IOS_SECRETE",
				crashReportingEnabled: true
			)
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

