using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class DemoItem : ObservableObject
    {
        [ObservableProperty]
        public partial string Name { get; set; } = "";

        [ObservableProperty]
        public partial int Counter { get; set; } = 0;
    }

    public partial class SfListViewPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial DemoItem Item { get; set; }

        [ObservableProperty]
        public partial ObservableCollection<DemoItem> Items { get; set; } = [
            new() { Name = "Test1", Counter = 1 },
            new() { Name = "Test2", Counter = 2 },
            new() { Name = "Test3", Counter = 3 },
            new() { Name = "Test4", Counter = 4 },
        ];

        [ObservableProperty]
        public partial int Index { get; set; } = 0;

        #endregion

        #region Constructor, LoadSettings

        public SfListViewPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
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
