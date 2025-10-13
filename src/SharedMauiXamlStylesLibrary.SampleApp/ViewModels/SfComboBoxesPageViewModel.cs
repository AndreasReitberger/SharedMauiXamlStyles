using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfComboBoxesPageViewModel : BaseViewModel
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

        #endregion

        #region Constructor, LoadSettings

        public SfComboBoxesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
