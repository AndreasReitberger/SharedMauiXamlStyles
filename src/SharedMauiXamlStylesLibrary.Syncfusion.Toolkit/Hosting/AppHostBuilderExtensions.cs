#if WINDOWS
using Microsoft.Maui.Handlers;
#endif
using AndreasReitberger.Shared.Hosting;
using Syncfusion.Maui.Toolkit.Hosting;

namespace AndreasReitberger.Shared.Syncfusion.Toolkit.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder InitializeSharedSyncfusionToolkitStyles(this MauiAppBuilder builder)
        {
            builder
                .ConfigureFonts(fonts =>
                {
                    FontDescriptor? fontDescriptor = fonts.FirstOrDefault(f => f.Filename == "MauiMaterialAssets.ttf");
                    if (fontDescriptor == null)
                    {
                        fonts.AddFont("MauiMaterialAssets.ttf", "MauiMaterialAssets");
                    }
                })
                .InitializeSharedMauiStyles()
                .ConfigureSyncfusionAddons()
                ;
            return builder;
        }
        public static MauiAppBuilder ConfigureSyncfusionAddons(this MauiAppBuilder builder)
        {
            builder
                .ConfigureSyncfusionToolkit()
                ;
            return builder;
        }
    }
}
