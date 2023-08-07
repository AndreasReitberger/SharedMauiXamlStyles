using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string sampleText = "This is just a sample text";

        #endregion

        #region Constructor, LoadSettings

        public AppShellViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
