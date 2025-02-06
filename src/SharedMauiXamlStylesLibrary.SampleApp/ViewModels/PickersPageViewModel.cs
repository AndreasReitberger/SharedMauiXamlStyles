using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class PickersPageViewModel : BaseViewModel
    {

        #region Properties
        [ObservableProperty]
        public partial ObservableCollection<string> Items { get; set; } =
        [
        "Item 1",
            "Item 2",
            "Item 3",
        ];

        [ObservableProperty]
        public partial string SelectedItem { get; set; } = "";

        [ObservableProperty]
        public partial DateTime SelectedDate { get; set; } = DateTime.MinValue;

        [ObservableProperty]
        public partial TimeSpan SelectedTime { get; set; } = TimeSpan.Zero;

        #endregion

        #region Constructor, LoadSettings

        public PickersPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
