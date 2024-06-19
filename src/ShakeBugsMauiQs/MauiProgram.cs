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
				androidApiKey: "Nkmiy9A0KGdoMdJY5VUHiHATvVDKwpprSJYdXeUS6J0H6RnxIMCBPTl",
                iosApiKey: "mxNV8yHc2hJnDTIhEddfwKYUJjlAw1vBJH068QWMQjtVGjHqyvaHMpc",
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

