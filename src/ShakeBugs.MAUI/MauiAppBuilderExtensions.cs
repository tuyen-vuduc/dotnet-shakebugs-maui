#if __ANDROID__
using Com.Shakebugs.Shake;
using Microsoft.Maui.LifecycleEvents;
#elif __IOS__
using Microsoft.Maui.LifecycleEvents;
using Shake;
#endif

namespace ShakeBugs;

public static class MauiAppBuilderExtensions
{
    private static bool initialized = false;
    public static MauiAppBuilder UseShakeBugs(
        this MauiAppBuilder builder,
        string? androidApiKey,
        string? iosApiKey,
        bool crashReportingEnabled = true)
    {
#if __ANDROID__
        if (!string.IsNullOrWhiteSpace(androidApiKey))
        {
            builder.ConfigureLifecycleEvents(lifeCycle =>
            {
                lifeCycle.AddAndroid(alc =>
                {
                    alc.OnCreate((activity, bundle) =>
                    {
                        if (initialized) return;
                        
                        initialized = true;

                        Shake.Start(
                            activity,
                            androidApiKey);
                    });
                });
            });
        }

        Shake.CrashReportingEnabled = crashReportingEnabled;
#elif __IOS__
        if (!string.IsNullOrWhiteSpace(iosApiKey))
        {
            builder.ConfigureLifecycleEvents(lifeCycle =>
            {
                lifeCycle.AddiOS(ilc =>
                {
                    ilc.OnActivated((app) =>
                    {
                        if (initialized) return;
                        
                        initialized = true;

                        SHKShake.StartWithApiKey(
                            iosApiKey);
                    });
                });
            });

        }
        SHKShake.Configuration.IsCrashReportingEnabled = crashReportingEnabled;
#endif

        return builder;
    }
}