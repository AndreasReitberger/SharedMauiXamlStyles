using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace AndreasReitberger.Shared.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder RegisterSharedFonts(this MauiAppBuilder builder)
        {
            builder.UseMauiCompatibility();
            builder.ConfigureFonts(fonts =>
            {
                foreach (KeyValuePair<string, string> font in SharedFonts.Fonts)
                {
                    // Avoid duplicates
                    FontDescriptor fontDescriptor = fonts.FirstOrDefault(f => f.Filename == font.Key);
                    if (fontDescriptor == null)
                        fonts.AddFont(font.Key, font.Value);
                }
            });
            return builder;
        }
    }
}
