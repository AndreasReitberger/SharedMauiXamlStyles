using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class PickersPageViewModel : BaseViewModel
    {

        #region Properties
        [ObservableProperty]
        ObservableCollection<string> items =
        [
        "Item 1",
            "Item 2",
            "Item 3",
        ];

        [ObservableProperty]
        string selectedItem = "";

        [ObservableProperty]
        DateTime selectedDate = DateTime.MinValue;

        [ObservableProperty]
        TimeSpan selectedTime = TimeSpan.Zero;

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
