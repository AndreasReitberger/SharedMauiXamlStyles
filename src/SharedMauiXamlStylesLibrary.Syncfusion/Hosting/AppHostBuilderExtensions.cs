using Microsoft.Maui.Handlers;
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
            ConfigureSharedStyleMappers();
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
                        FontDescriptor? fontDescriptor = fonts.FirstOrDefault(f => f.Filename == font.Key);
                        if (fontDescriptor == null)
                        {
                            //fonts.AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, font.Key, font.Value);
                            fonts.AddFont(font.Key, font.Value);
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


        /// <summary>
        /// Configure custom mappers.
        /// </summary>
        public static void ConfigureSharedStyleMappers()
        {
#if WINDOWS

            // Fixed according to this post: https://feedback.telerik.com/maui/1635441-icon-not-displayed-when-using-windowspackagetype-none-windowspackagetype
#if Workaround_9104
            ///Ref: https://github.com/dotnet/maui/issues/9104#issuecomment-1623140740
            LabelHandler.Mapper.AppendToMapping("FontFamily", (handler, element) =>
            {
                if (element.Font.Family == "UIFontIcons")
                {
                    // "UIFontIcons.ttf", "UIFontIcons" 
                    const string FontAwesomeFamily = "ms-appx:///UIFontIcons.ttf#UIFontIcons";
                    handler.PlatformView.FontFamily = new Microsoft.UI.Xaml.Media.FontFamily(FontAwesomeFamily);
                }
            });
#endif
#endif
        }
    }
}
