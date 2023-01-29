﻿using Microsoft.Maui.Controls.Compatibility.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace AndreasReitberger.Shared.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder InitializeSharedMauiStyles(this MauiAppBuilder builder)
        {
            builder
                .RegisterSharedFonts()
                .ConfigureSyncfusionAddons()
                ;
            return builder;
        }

        public static MauiAppBuilder RegisterSharedFonts(this MauiAppBuilder builder)
        {
            builder
                .UseMauiCompatibility()
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
                .UseMauiCompatibility()
                .ConfigureSyncfusionCore()
                ;
            return builder;
        }
    }
}