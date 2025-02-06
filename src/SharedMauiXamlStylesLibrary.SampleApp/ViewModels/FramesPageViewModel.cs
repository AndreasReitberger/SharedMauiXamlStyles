using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class FramesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial double Progress { get; set; } = 0.50;

        [ObservableProperty]
        public partial double ProgressSecond { get; set; } = 0.75;

        [ObservableProperty]
        public partial bool RefreshOnPageAppearing { get; set; } = false;

        [ObservableProperty]
        public partial bool ConfirmPageClosing { get; set; } = false;

        #endregion

        #region Constructor, LoadSettings

        public FramesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
