using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfShimmerPageViewModel : BaseViewModel
    {
        #region Properties

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RetryCommand))]
        public new partial bool IsBusy { get; set; } = false;

        #endregion

        #region Constructor, LoadSettings

        public SfShimmerPageViewModel(IDispatcher dispatcher, IServiceProvider provider, IFileSaver fileSaver) : base(dispatcher, provider, fileSaver)
        {
            Dispatcher = dispatcher;
        }

        #endregion

        #region Commands

        bool Retry_CanExecute => !IsBusy;
        [RelayCommand(CanExecute = nameof(Retry_CanExecute))]
        Task Retry() => OnAppearing();
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
