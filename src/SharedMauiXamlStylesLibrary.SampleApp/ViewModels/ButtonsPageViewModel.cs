using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class ButtonsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string sampleText = "This is just a sample text";

        [ObservableProperty]
        bool enabled = true;
        #endregion

        #region Constructor, LoadSettings

        public ButtonsPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
