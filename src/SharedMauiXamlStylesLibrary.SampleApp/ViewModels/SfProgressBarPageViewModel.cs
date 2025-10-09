using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfProgressBarPageViewModel : BaseViewModel
    {
        #region Properties

        [ObservableProperty]
        public new partial int Progress { get; set; } = 0;

        #endregion

        #region Constructor, LoadSettings

        public SfProgressBarPageViewModel(IDispatcher dispatcher, IServiceProvider provider, IFileSaver fileSaver) : base(dispatcher, provider, fileSaver)
        {
            Dispatcher = dispatcher;
        }

        #endregion

        #region LifeCycle

        public async Task OnAppearing()
        {
            IsBusy = true;
            await Task.Delay(5000);
            IsBusy = false;
        }

        #endregion
    }
}
