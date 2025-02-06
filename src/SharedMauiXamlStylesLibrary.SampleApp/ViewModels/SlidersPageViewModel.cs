using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SlidersPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial double Progress { get; set; } = 0.50;

        [ObservableProperty]
        public partial double ProgressSecond { get; set; } = 0.75;

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
