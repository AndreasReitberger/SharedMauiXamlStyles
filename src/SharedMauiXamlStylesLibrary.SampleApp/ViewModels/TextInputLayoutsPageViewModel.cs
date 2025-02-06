using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class TextInputLayoutsPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public partial string Name { get; set; } = "This is just a sample text";

        [ObservableProperty]
        public partial double PackageSize { get; set; } = 5.34;

        [ObservableProperty]
        public partial double Price { get; set; } = 19.99;
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
