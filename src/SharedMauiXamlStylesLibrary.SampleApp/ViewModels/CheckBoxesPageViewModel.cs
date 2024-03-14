using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class CheckBoxesPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string sampleText = "This is just a sample text";

        [ObservableProperty]
        bool isChecked = false;
        #endregion

        #region Constructor, LoadSettings

        public CheckBoxesPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
