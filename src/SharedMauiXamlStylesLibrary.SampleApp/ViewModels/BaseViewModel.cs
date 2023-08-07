﻿using AndreasReitberger.Shared.Core;
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
        string version = string.Empty;

        [ObservableProperty]
        string build = string.Empty;

        [ObservableProperty]
        bool isTabletMode = false;

        [ObservableProperty]
        double progress = 0;

        [ObservableProperty]
        bool licenseActivationShown = false;
        #endregion

        #region Navigation
        [ObservableProperty]
        bool isViewShown = false;

        #endregion

        #region Connection
        [ObservableProperty]
        bool isConnecting = false;

        #endregion

        #region States
        [ObservableProperty]
        bool isListening = false;

        [ObservableProperty]
        bool isListeningToWebSocket = false;

        [ObservableProperty]
        bool closeWebSocketWhenLeaving = false;

        #endregion

        #region Theme
        [ObservableProperty]
        bool darkmode = false;
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
        string hexCode = string.Empty;
        partial void OnHexCodeChanged(string value)
        {
            if (!IsLoading)
            {
                //SettingsApp.Theme_PrimaryThemeColor = value;
                //SettingsApp.SettingsChanged = true;
                ThemeManager.Instance.UpdatePrimaryThemeColor(ThemeManager.Instance.FindThemeOrDefault(value), Application.Current);
                ThemeManager.Instance.UpdatePlatformThemeColor(ThemeManager.Instance.FindThemeOrDefault(value));
            }
        }
        #endregion

        #region Constructor
        public BaseViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            Provider = provider;

            UpdateVersionBuild();
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
