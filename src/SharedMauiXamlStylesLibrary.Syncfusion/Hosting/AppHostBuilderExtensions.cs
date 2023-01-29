using AndreasReitberger.Shared.Hosting;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace AndreasReitberger.Shared.Syncfusion.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder InitializeSharedSyncfusionStyles(this MauiAppBuilder builder)
        {
            builder
                .RegisterSharedFonts()
                .ConfigureSyncfusionAddons()
                ;
            return builder;
        }

        public static MauiAppBuilder ConfigureSyncfusionAddons(this MauiAppBuilder builder)
        {
            builder
                .UseMauiCompatibility()
                .ConfigureSyncfusionCore()
                ;
            return builder;
        }
    }
}
