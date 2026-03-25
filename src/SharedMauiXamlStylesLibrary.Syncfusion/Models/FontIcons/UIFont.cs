using Microsoft.Maui.Controls.Internals;

namespace AndreasReitberger.Shared.Syncfusion.FontIcons
{
    [Preserve(AllMembers = true)]
    public static class UIFont
    {
        /// <summary>
        /// The font family alias for the default (Regular) icon font style.
        /// </summary>
        public static string FontFamily => IconFontConfigs.Default.FontAlias;

        /// <summary>
        /// Creates a <see cref="FontImageSource"/> using glyphs emitted by the source generator.
        /// </summary>
        /// <param name="glyph">The glyph string, typically retrieved from <c>FluentIconsRegular</c> or <c>FluentIconsFilled</c>.</param>
        /// <param name="color">Optional foreground color; defaults to <see cref="Microsoft.Maui.Graphics.Colors.Black"/>.</param>
        /// <param name="size">Icon size in device-independent units.</param>
        public static FontImageSource Create(string glyph, Color? color = null, double size = 24d)
        {
            return new FontImageSource
            {
                FontFamily = FontFamily,
                Glyph = glyph,
                Color = color ?? Microsoft.Maui.Graphics.Colors.Black,
                Size = size
            };
        }
    }
}
