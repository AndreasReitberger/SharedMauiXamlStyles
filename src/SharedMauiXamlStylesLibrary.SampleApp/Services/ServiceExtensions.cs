﻿namespace SharedMauiXamlStylesLibrary.SampleApp.Services
{
    /// <summary>
    /// Source: https://github.com/davidortinau/WeatherTwentyOne/blob/main/src/WeatherTwentyOne/Services/ServiceExtensions.cs
    /// </summary>
    public static class ServiceProvider
    {
        public static TService GetService<TService>()
            => Current.GetService<TService>();

        public static IServiceProvider Current => IPlatformApplication.Current.Services;
        /*
#if WINDOWS10_0_17763_0_OR_GREATER
            MauiWinUIApplication.Current.Services;
#elif ANDROID
            MauiApplication.Current.Services;
#elif IOS || MACCATALYST
            MauiUIApplicationDelegate.Current.Services;
#else
            null;
#endif
        */
    }
}
