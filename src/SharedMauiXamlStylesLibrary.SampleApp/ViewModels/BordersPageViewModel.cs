using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class BordersPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public new partial double Progress { get; set; } = 0.50;

        [ObservableProperty]
        public partial double ProgressSecond { get; set; } = 0.75;

        [ObservableProperty]
        public partial bool RefreshOnPageAppearing { get; set; } = false;

        [ObservableProperty]
        public partial bool ConfirmPageClosing { get; set; } = false;

        #endregion

        #region Constructor, LoadSettings

        public BordersPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
