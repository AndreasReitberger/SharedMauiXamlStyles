namespace SharedMauiXamlStylesLibrary.SampleApp.Services
{
    /// <summary>
    /// Source: https://github.com/davidortinau/WeatherTwentyOne/blob/main/src/WeatherTwentyOne/Services/ServiceExtensions.cs
    /// </summary>
    public static class ServiceProvider
    {
        public static TService? GetService<TService>()
            => Current is not null ? Current.GetService<TService>() : default;

        public static IServiceProvider? Current => IPlatformApplication.Current?.Services;
    }
}
