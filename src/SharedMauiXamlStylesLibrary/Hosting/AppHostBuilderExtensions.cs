using Microsoft.Maui.Handlers;

namespace AndreasReitberger.Shared.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder InitializeSharedMauiStyles(this MauiAppBuilder builder)
        {
            builder
                .RegisterSharedFonts()
                ;
            ConfigureSharedStyleMappers();
            return builder;
        }

        public static MauiAppBuilder RegisterSharedFonts(this MauiAppBuilder builder)
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

        /// <summary>
        /// Configure custom mappers.
        /// </summary>
        public static void ConfigureSharedStyleMappers()
        {
#if WINDOWS
            ///Ref: https://github.com/dotnet/maui/issues/16047
            SwitchHandler.Mapper.AppendToMapping("CustomLabelSwitch", (handler, control) =>
            {
                handler.PlatformView.OnContent = null; // new Label { Text = "Foo", TextColor = Colors.Red }.ToPlatform(handler.MauiContext);
                handler.PlatformView.OffContent = null;
            });
#if Workaround_9104
            ///Ref: https://github.com/dotnet/maui/issues/9104#issuecomment-1623140740
            LabelHandler.Mapper.AppendToMapping("FontFamily", (handler, element) =>
            {
                if (element.Font.Family == "MaterialDesignIcons")
                {
                    const string FontAwesomeFamily = "ms-appx:///materialdesignicons-webfont.ttf#MaterialDesignIcons";
                    handler.PlatformView.FontFamily = new Microsoft.UI.Xaml.Media.FontFamily(FontAwesomeFamily);
                }
            });
#endif
#endif
        }
    }
}
