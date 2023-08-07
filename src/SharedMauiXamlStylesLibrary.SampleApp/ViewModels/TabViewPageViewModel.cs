using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class TabViewPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string sampleText = "This is just a sample text";

        #endregion

        #region Constructor, LoadSettings

        public TabViewPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
