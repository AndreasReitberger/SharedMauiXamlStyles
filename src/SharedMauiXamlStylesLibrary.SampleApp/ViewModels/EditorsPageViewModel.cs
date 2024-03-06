using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class EditorsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string exampleText = "This is a small text example...";

        [ObservableProperty]
        string exampleTextLong = "This is a very long text example for an editor control...";

        #endregion

        #region Constructor, LoadSettings

        public EditorsPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
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
