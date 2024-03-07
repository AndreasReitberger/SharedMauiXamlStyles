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
        ObservableCollection<ThemeColorInfo> themes = new();

        [ObservableProperty]
        ThemeColorInfo theme;
        partial void OnThemeChanged(ThemeColorInfo value)
        {
            HexCode = value?.PrimaryColor.ToArgbHex();
        }
        #endregion

        #region Constructor, LoadSettings

        public AppShellViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();

            LoadSettings();

            Darkmode = App.Current.UserAppTheme == AppTheme.Dark;
        }
        void LoadSettings()
        {
            IsLoading = true;
            Themes = new(ThemeManager.Instance.AvailableThemes);
            Theme =
                Themes?.FirstOrDefault(theme => theme.PrimaryColor?.ToArgbHex() == HexCode) ??
                Themes?.FirstOrDefault();
            IsLoading = false;
        }
        #endregion

    }
}
