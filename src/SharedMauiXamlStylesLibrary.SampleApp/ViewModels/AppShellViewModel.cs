using AndreasReitberger.Shared.Core.Theme;
using CommunityToolkit.Mvvm.ComponentModel;
using SharedMauiXamlStylesLibrary.SampleApp.Utilities;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial ObservableCollection<ThemeColorInfo> Themes { get; set; } = [];

        [ObservableProperty]
        public partial ThemeColorInfo? Theme { get; set; }

        partial void OnThemeChanged(ThemeColorInfo? value)
        {
            if (value?.PrimaryColor is not null)
                HexCode = value.PrimaryColor.ToArgbHex();
        }
        #endregion

        #region Constructor, LoadSettings

        public AppShellViewModel(IDispatcher dispatcher, IServiceProvider? provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            Provider = provider;
            UpdateVersionBuild();

            LoadSettings();
            if (Application.Current?.UserAppTheme is not AppTheme.Unspecified)
                Darkmode = Application.Current?.UserAppTheme == AppTheme.Dark;
            else
                Darkmode = Application.Current?.PlatformAppTheme == AppTheme.Dark;
        }
        void LoadSettings()
        {
            IsLoading = true;
            Themes = new(ThemeManager.Instance.AvailableThemes);
            Theme =
                Themes.FirstOrDefault(theme => theme.PrimaryColor?.ToArgbHex() == HexCode) ??
                Themes.FirstOrDefault();
            IsLoading = false;
        }
        #endregion

    }
}
