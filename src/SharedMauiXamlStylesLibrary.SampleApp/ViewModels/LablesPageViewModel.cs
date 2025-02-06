using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class LablesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial string SampleText { get; set; } = "This is just a sample text";

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
