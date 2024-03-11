using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class ComboBoxesPageViewModel : BaseViewModel
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

        #endregion

        #region Constructor, LoadSettings

        public ComboBoxesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
