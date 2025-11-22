using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using Syncfusion.Maui.ProgressBar;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfStepProgressBarViewModel : BaseViewModel
    {
        #region Properties

        [ObservableProperty]
        public partial ObservableCollection<StepProgressBarItem> StepProgress { get; set; } =
        [
            new () { PrimaryText = "Packaged"},
            new () { PrimaryText = "Shipped"},
            new () { PrimaryText = "Delivered"},
        ];

        [ObservableProperty]
        public partial int SelectedIndex { get; set; } = 0;
        #endregion

        #region Constructor, LoadSettings

        public SfStepProgressBarViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
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
