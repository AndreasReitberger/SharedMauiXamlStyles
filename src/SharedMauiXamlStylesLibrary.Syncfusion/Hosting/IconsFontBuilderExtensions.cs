using AndreasReitberger.Shared.FontIcons;

namespace AndreasReitberger.Shared.Syncfusion
{
    public static partial class AppHostBuilderExtensions
    {
        public static MauiAppBuilder RegisterUIIconFonts(this MauiAppBuilder builder)
        {
            // Register Icon fonts
            builder.ConfigureFonts(fonts =>
            {
                foreach (IconFontConfig? cfg in IconFontConfigs.All)
                {
                    fonts.AddFont(cfg.FontFile, cfg.FontAlias);
                }
            });
            return builder;
        }

        internal static MauiAppBuilder UseIconFont(this MauiAppBuilder builder, string fontClass)
        {
            IconFontConfig? cfg = Array.Find(IconFontConfigs.All, x => x.ClassName == fontClass);
            if (cfg is not null)
            {
                builder.ConfigureFonts(fonts => fonts.AddFont(cfg.FontFile, cfg.FontAlias));
            }
            return builder;
        }
    }
}
