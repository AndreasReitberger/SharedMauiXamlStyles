using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SlidersPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        double progress = 0.50;

        [ObservableProperty]
        double progressSecond = 0.75;

        #endregion

        #region Constructor, LoadSettings

        public SlidersPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
