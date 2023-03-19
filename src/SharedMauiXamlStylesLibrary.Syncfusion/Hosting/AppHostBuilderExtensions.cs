using Syncfusion.Maui.Core.Hosting;

namespace AndreasReitberger.Shared.Syncfusion.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder InitializeSharedSyncfusionStyles(this MauiAppBuilder builder)
        {
            builder
                .RegisterSharedSyncfusionFonts()
                .ConfigureSyncfusionAddons()
                ;
            return builder;
        }
        public static MauiAppBuilder RegisterSharedSyncfusionFonts(this MauiAppBuilder builder)
        {
            builder
                .ConfigureFonts(fonts =>
                {
                    foreach (KeyValuePair<string, string> font in SharedFonts.Fonts)
                    {
                        // Avoid duplicates
                        FontDescriptor fontDescriptor = fonts.FirstOrDefault(f => f.Filename == font.Key);
                        if (fontDescriptor == null)
                        {
                            fonts.AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, font.Key, font.Value);
                            //fonts.AddFont(font.Key, font.Value);
                        }
                    }
                });
            return builder;
        }
        public static MauiAppBuilder ConfigureSyncfusionAddons(this MauiAppBuilder builder)
        {
            builder
                .ConfigureSyncfusionCore()
                ;
            return builder;
        }
    }
}
