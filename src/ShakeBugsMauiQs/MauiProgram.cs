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
				androidId: "LXpNiJmtFQf14i4JETcDJ8m4bsCEAHonolPiall2",
				androidSecret: "osl3pxUKPQ75oAk3MWuIlQ6wg0ovI3pVWHYcEJiReCbBI2RMxfQjqXU",
                iosId: "k5jbo7LrFWrDZKklJzDEaLmypWWqrF0wNz6RNnqv",
				iosSecret: "AzEpJrnZTswcwreOUBRtL4LGYv26kOaWOGYWpz9IKPVBBXcfAC1AnrJ",
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

