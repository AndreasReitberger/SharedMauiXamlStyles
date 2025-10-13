using AndreasReitberger.Shared.Core;
using AndreasReitberger.Shared.Core.Interfaces;
using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using SharedMauiXamlStylesLibrary.SampleApp.Utilities;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class BaseViewModel : ViewModelBase
    {
        #region App
        [ObservableProperty]
        public partial string Version { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Build { get; set; } = string.Empty;

        [ObservableProperty]
        public partial bool IsTabletMode { get; set; } = false;

        [ObservableProperty]
        public partial double Progress { get; set; } = 0;

        [ObservableProperty]
        public partial bool LicenseActivationShown { get; set; } = false;

        [ObservableProperty]
        public partial ILocalizationManager? LocalizationManager { get; set; }

        #endregion

        #region Navigation
        [ObservableProperty]
        public partial bool IsViewShown { get; set; } = false;

        #endregion

        #region Connection
        [ObservableProperty]
        public partial bool IsConnecting { get; set; } = false;

        #endregion

        #region States

        [ObservableProperty]
        public partial bool Enabled { get; set; } = true;

        [ObservableProperty]
        public partial bool IsListening { get; set; } = false;

        [ObservableProperty]
        public partial bool IsListeningToWebSocket { get; set; } = false;

        [ObservableProperty]
        public partial bool CloseWebSocketWhenLeaving { get; set; } = false;

        #endregion

        #region Theme
        [ObservableProperty]
        public partial bool Darkmode { get; set; } = false;

        partial void OnDarkmodeChanged(bool value)
        {
            if (!IsLoading)
            {
                //SettingsApp.Theme_UseDarkTheme = value;
                //SettingsApp.SettingsChanged = true;
                ThemeManager.Instance.ApplyTheme(value ? AppTheme.Dark : AppTheme.Light, Application.Current);
            }
        }


        [ObservableProperty]
        public partial string HexCode { get; set; } = string.Empty;

        partial void OnHexCodeChanged(string value)
        {
            if (!IsLoading)
            {
                //SettingsApp.Theme_PrimaryThemeColor = value;
                //SettingsApp.SettingsChanged = true;
                ThemeManager.Instance.UpdatePrimaryThemeColor(ThemeManager.Instance.FindThemeOrDefault(value), Application.Current);
                ThemeManager.UpdatePlatformThemeColor(ThemeManager.Instance.FindThemeOrDefault(value));
            }
        }
        #endregion

        #region Constructor
        public BaseViewModel(IDispatcher dispatcher, IServiceProvider? provider) : base(dispatcher, provider)
        {
            InitializeLocalizeManager();
            Dispatcher = dispatcher;
            Provider = provider;

            UpdateVersionBuild();
        }
        public BaseViewModel(IDispatcher dispatcher, IServiceProvider? provider, IFileSaver? fileSaver) : base(dispatcher, provider, fileSaver)
        {
            InitializeLocalizeManager();
            Dispatcher = dispatcher;
            Provider = provider;
            FileSaver = fileSaver;

            UpdateVersionBuild();
        }
        protected void InitializeLocalizeManager()
        {
            LocalizationManager = Provider?.GetServices<ILocalizationManager>().First();
            if (LocalizationManager is not null)
            {
                //LocalizationManager.LanguageChanged += LocalizationManager_LanguageChanged;
                //CurrentLanguage = LocalizationManager.CurrentLanguage;
            }
        }
        #endregion

        #region Destructor
        ~BaseViewModel()
        {
            // Unregisters all when the ViewModel is GC.
            WeakReferenceMessenger.Default.UnregisterAll(this);
        }
        #endregion

        #region Commands

        #region Navigation

        [RelayCommand]
        protected Task Close() => Back();

        [RelayCommand]
        protected Task Back() => Shell.Current.GoToAsync("..");

        #endregion

        #endregion

        #region Methods

        #region Build
        protected void UpdateVersionBuild()
        {
            try
            {
                Version = AppInfo.VersionString;
                Build = AppInfo.BuildString;
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #endregion

        #region LiveCycle

        public void OnDisappearing()
        {

        }
        #endregion
    }
}
