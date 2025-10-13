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
        public partial LocalizationInfo Language { get; set; }

        [ObservableProperty]
        public partial ObservableCollection<LocalizationInfo> Languages { get; set; } = [];

        [ObservableProperty]
        public partial int Index { get; set; } = 0;

        #endregion

        #region Constructor, LoadSettings

        public LanguagesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();

            Languages = [.. LocalizationManager?.Languages];
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
