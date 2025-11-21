using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class GridsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial bool RefreshOnPageAppearing { get; set; } = false;

        [ObservableProperty]
        public partial bool ConfirmPageClosing { get; set; } = false;

        #endregion

        #region Constructor, LoadSettings

        public GridsPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

        #region Commands

        [RelayCommand]
        Task DeleteAllSettings() => Shell.Current.DisplayAlertAsync("Content deleted!", "All content has been deleted (not, this is just a demo message ;))", "OK");

        #endregion
    }
}
