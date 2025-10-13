using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfTabViewPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial string SampleText { get; set; } = "This is just a sample text";

        #endregion

        #region Constructor, LoadSettings

        public SfTabViewPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
