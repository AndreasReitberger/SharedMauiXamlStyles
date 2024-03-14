using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class LablesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string sampleText = "This is just a sample text";

        #endregion

        #region Constructor, LoadSettings

        public LablesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
