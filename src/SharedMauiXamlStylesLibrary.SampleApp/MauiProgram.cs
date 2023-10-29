using AndreasReitberger.Shared.Hosting;
using AndreasReitberger.Shared.Syncfusion.Hosting;
using Microsoft.Extensions.Logging;
using SharedMauiXamlStylesLibrary.SampleApp.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .InitializeSharedMauiStyles()
                .InitializeSharedSyncfusionStyles()
                .ConfigureApp()
                .ConfigureDispatching() //https://github.com/dotnet/maui/blob/main/src/Core/src/Hosting/Dispatching/AppHostBuilderExtensions.cs
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
}