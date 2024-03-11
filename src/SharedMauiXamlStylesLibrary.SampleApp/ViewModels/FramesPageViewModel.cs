using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class FramesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        double progress = 0.50;

        [ObservableProperty]
        double progressSecond = 0.75;

        [ObservableProperty]
        bool refreshOnPageAppearing = false;

        [ObservableProperty]
        bool confirmPageClosing = false;

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
