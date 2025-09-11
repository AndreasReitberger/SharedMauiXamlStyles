using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfChatPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial string SampleText { get; set; } = "This is just a sample text";

        [ObservableProperty]
        public partial bool IsChecked { get; set; } = false;
        #endregion

        #region Constructor, LoadSettings

        public SfChatPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
