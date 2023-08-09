using AndreasReitberger.Shared.Core.Services;
using AndreasReitberger.Shared.Core.Theme;
using AndreasReitberger.Shared.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace SharedMauiXamlStylesLibrary.SampleApp.Utilities
{
    public partial class ThemeManager : ObservableObject, IThemeManager
    {
        #region Instance
        static ThemeManager _instance = null;
        static readonly object Lock = new();
        public static ThemeManager Instance
        {
            get
            {
                lock (Lock)
                {
                    if (_instance == null)
                        _instance = new ThemeManager();
                }
                return _instance;
            }

            set
            {
                if (_instance == value) return;
                lock (Lock)
                {
                    _instance = value;
                }
            }

        }
        #endregion

        #region Properties
        public AppTheme Theme { get; } = AppTheme.Light;

        [ObservableProperty]
        List<ThemeColorInfo> availableThemes = new()
        {
            new ThemeColorInfo() { ThemeName = "Default", PrimaryColor = Color.FromArgb("#377dff"), IsAppDefault = true },
            new ThemeColorInfo() { ThemeName = Colors.Gray.ToHex(), PrimaryColor = Colors.Gray },
            new ThemeColorInfo() { ThemeName = Colors.Brown.ToHex(), PrimaryColor = Colors.Brown },
            new ThemeColorInfo() { ThemeName = Colors.Green.ToHex(), PrimaryColor = Colors.Green },
            new ThemeColorInfo() { ThemeName = Colors.Red.ToHex(), PrimaryColor = Colors.Red },
            new ThemeColorInfo() { ThemeName = Colors.Orange.ToHex(), PrimaryColor = Colors.Orange },
            new ThemeColorInfo() { ThemeName = Colors.Blue.ToHex(), PrimaryColor = Colors.Blue },
            new ThemeColorInfo() { ThemeName = Colors.LightGray.ToHex(), PrimaryColor = Colors.LightGray },
            new ThemeColorInfo() { ThemeName = Colors.Teal.ToHex(), PrimaryColor = Colors.Teal },
            new ThemeColorInfo() { ThemeName = Colors.Purple.ToHex(), PrimaryColor = Colors.Purple },
            new ThemeColorInfo() { ThemeName = Colors.Pink.ToHex(), PrimaryColor = Colors.Pink },
            new ThemeColorInfo() { ThemeName = Colors.Beige.ToHex(), PrimaryColor = Colors.Beige },
            new ThemeColorInfo() { ThemeName = Colors.Violet.ToHex(), PrimaryColor = Colors.Violet },
            new ThemeColorInfo() { ThemeName = Colors.Silver.ToHex(), PrimaryColor = Colors.Silver },
            new ThemeColorInfo() { ThemeName = Colors.Gold.ToHex(), PrimaryColor = Colors.Gold },
        };

        [ObservableProperty]
        public ThemeColorInfo selectedTheme;

        public ThemeColorInfo AppDefaultTheme => AvailableThemes?.FirstOrDefault(themeInfo => themeInfo.IsAppDefault);
        #endregion

        #region Methods
        public void ApplyTheme(AppTheme theme, Application app)
        {
            try
            {
                if (app.UserAppTheme != theme)
                    app.UserAppTheme = theme;
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
            }

        }

        /// <summary>
        /// Updates the `PrimaryColor` and its dependencies in the App.Resources
        /// </summary>
        /// <param name="theme">The ThemeColorInfo to be changed to</param>
        /// <param name="app">The current app</param>
        public void UpdatePrimaryThemeColor(ThemeColorInfo theme, Application app)
        {
            try
            {
                if (SelectedTheme == theme) return;
                SelectedTheme = theme;
                app.Resources["PrimaryColor"] = theme.PrimaryColor;
                app.Resources["GradientStart"] = theme.PrimaryColor;

                app.Resources["PrimaryDarkenColor"] = theme.PrimaryDarkerColor;
                app.Resources["GradientEnd"] = theme.PrimaryDarkerColor;

                app.Resources["PrimaryLighterColor"] = theme.PrimaryLigtherColor;

                if (theme.SecondaryColor != null)
                {
                    app.Resources["Secondary"] = theme.PrimaryDarkerColor;
                    app.Resources["SecondaryGradient"] = theme.PrimaryDarkerColor;
                }

#if DEBUG
                Console.WriteLine("Colors updated:\n" +
                    $"primary:      {theme.PrimaryColor?.ToHex()}\n" +
                    $"primary_darker: {theme.PrimaryDarkerColor?.ToHex()}\n" +
                    $"primary_ligther: {theme.PrimaryLigtherColor?.ToHex()}\n" +
                    $"secondary: {theme.SecondaryColor?.ToHex()}"
                    );
#endif
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
            }
        }

        /// <summary>
        /// Updates the `PrimaryColor` for platform specific resources, as the StatusBar
        /// </summary>
        /// <param name="theme">The ThemeColorInfo to be changed to</param>
        public void UpdatePlatformThemeColor(ThemeColorInfo theme)
        {
            try
            {
                new PlatformThemeService()?.SetStatusBarColor(theme?.PrimaryColor);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
            }
        }

        public ThemeColorInfo FindTheme(string primaryColorHexCode, bool createCustomIfNull = true) => AvailableThemes?.FirstOrDefault(theme => theme.PrimaryColor?.ToArgbHex() == primaryColorHexCode) ??
            (createCustomIfNull ? new ThemeColorInfo() { ThemeName = primaryColorHexCode, PrimaryColor = Color.FromArgb(primaryColorHexCode) } : null);

        public ThemeColorInfo FindThemeOrDefault(string primaryColorHexCode) => FindTheme(primaryColorHexCode) ?? AppDefaultTheme;

        public Color GetThemeColorFromResource(string resourceName, Application app = null)
        {
            try
            {
                Application instance = app ?? Application.Current;
                instance.Resources.TryGetValue(resourceName, out object resource);
                if (resource is Color color)
                {
                    return color;
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
            }
            return null;
        }
        #endregion
    }
}
