#if __ANDROID__
using Com.Shakebugs.Shake;
#elif __IOS__
using Shake;
#endif

namespace ShakeBugs;

public static class MauiAppBuilderExtensions
{
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
            Shake.Start(
                Platform.CurrentActivity,
                androidId,
                androidSecret);
        }
        Shake.CrashReportingEnabled = crashReportingEnabled;
#elif __IOS__
        if (!string.IsNullOrWhiteSpace(iosId)
            && !string.IsNullOrWhiteSpace(iosSecret)) 
        {
            SHKShake.StartWithClientId(
                iosId,
                iosSecret);
        }
        SHKShake.Configuration.IsCrashReportingEnabled = crashReportingEnabled;
#endif

        return builder;
    }
}