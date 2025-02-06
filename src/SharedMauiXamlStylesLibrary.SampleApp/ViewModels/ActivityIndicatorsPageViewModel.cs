using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class ActivityIndicatorsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial bool Busy { get; set; } = true;
        #endregion

        #region Constructor, LoadSettings

        public ActivityIndicatorsPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
