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
