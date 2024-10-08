using AndreasReitberger.Shared.Core.Localization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{

    public partial class LanguagesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        LocalizationInfo language;

        [ObservableProperty]
        ObservableCollection<LocalizationInfo> languages = [
            new() { Name = "German", Code = "de-DE", Translator = "Andreas", PercentTranslated = 100, IsOfficial = true },
            new() { Name = "English", Code = "en-US", Translator = "Andreas", PercentTranslated = 75, IsOfficial = true },
            new() { Name = "Italian", Code = "it-IT", Translator = "Some other guy", PercentTranslated = 50, IsOfficial = false },
        ];

        [ObservableProperty]
        int index = 0;

        #endregion

        #region Constructor, LoadSettings

        public LanguagesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

        #region Command

        [RelayCommand]
        static Task Sort() => Shell.Current.DisplayAlert("Sort", "Sort command placeholder...", "OK");

        [RelayCommand]
        static Task Filter() => Shell.Current.DisplayAlert("Filter", "Filter command placeholder...", "OK");

        [RelayCommand]
        static Task Clear() => Shell.Current.DisplayAlert("Clear", "Clear command placeholder...", "OK");

        [RelayCommand]
        void ValueNext()
        {
            Index++;
        }
        [RelayCommand]
        void ValueBack()
        {
            Index--;
        }
        #endregion
    }
}
