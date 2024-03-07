using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SwitchesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        bool refreshOnPageAppearing = false;

        [ObservableProperty]
        bool confirmPageClosing = false;

        #endregion

        #region Constructor, LoadSettings

        public SwitchesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

        #region Commands

        [RelayCommand]
        Task DeleteAllSettings() =>  Shell.Current.DisplayAlert("Content deleted!", "All content has been deleted (not, this is just a demo message ;))", "OK");
        
        #endregion
    }
}
