using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class TextInputLayoutsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        string name = "This is just a sample text";

        [ObservableProperty]
        double packageSize = 5.34;

        [ObservableProperty]
        double price = 19.99;
        #endregion

        #region Constructor, LoadSettings

        public TextInputLayoutsPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
