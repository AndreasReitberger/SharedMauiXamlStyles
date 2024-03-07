using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class ProgressBarsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        double progress = 0.50;

        [ObservableProperty]
        double progressSecond = 0.75;

        #endregion

        #region Constructor, LoadSettings

        public ProgressBarsPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
