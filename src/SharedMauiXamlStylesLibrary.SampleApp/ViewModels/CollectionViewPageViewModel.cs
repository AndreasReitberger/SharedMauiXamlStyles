using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class CollectionViewPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        ObservableCollection<string> list =
        [
            "Text 1",
            "Text 2",
            "Text 3",
        ];

        #endregion

        #region Constructor, LoadSettings

        public CollectionViewPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
