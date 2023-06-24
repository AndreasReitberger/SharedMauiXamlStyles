using AndreasReitberger.Shared.Hosting;
using AndreasReitberger.Shared.Syncfusion.Hosting;
using Microsoft.Extensions.Logging;
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