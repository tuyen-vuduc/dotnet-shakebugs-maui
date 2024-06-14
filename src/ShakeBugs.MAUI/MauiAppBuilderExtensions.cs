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
        string? androidId = default, string? androidSecret = default,
        string? iosId = default, string? iosSecret = default,
        bool crashReportingEnabled = true)
    {
#if __ANDROID__
        if (!string.IsNullOrWhiteSpace(androidId)
            && !string.IsNullOrWhiteSpace(androidSecret))
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
                            androidId,
                            androidSecret);
                    });
                });
            });
        }

        Shake.CrashReportingEnabled = crashReportingEnabled;
#elif __IOS__
        if (!string.IsNullOrWhiteSpace(iosId)
            && !string.IsNullOrWhiteSpace(iosSecret))
        {
            builder.ConfigureLifecycleEvents(lifeCycle =>
            {
                lifeCycle.AddiOS(ilc =>
                {
                    ilc.OnActivated((app) =>
                    {
                        if (initialized) return;
                        
                        initialized = true;

                        SHKShake.StartWithClientId(
                            iosId,
                            iosSecret);
                    });
                });
            });

        }
        SHKShake.Configuration.IsCrashReportingEnabled = crashReportingEnabled;
#endif

        return builder;
    }
}