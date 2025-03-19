using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class TemplatePageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        public new partial double Progress { get; set; } = 0.50;

        [ObservableProperty]
        public partial double ProgressSecond { get; set; } = 0.75;

        [ObservableProperty]
        public partial bool IsLoggedIn { get; set; } = true;

        [ObservableProperty]
        public partial string SyncingText { get; set; } = "Is syncing...";

        [ObservableProperty]
        public partial string UserId { get; set; } = string.Empty;

        [ObservableProperty]
        public partial bool IsAnonymous { get; set; } = true;

        [ObservableProperty]
        public partial string Username { get; set; } = "Andreas";

        [ObservableProperty]
        public partial string UserFirstName { get; set; } = "Andreas";

        [ObservableProperty]
        public partial string UserLastName { get; set; } = "Reitberger";

        [ObservableProperty]
        public partial string UserDisplayName { get; set; } = "Andreas, Reitberger";

        [ObservableProperty]
        public partial string UserEmail { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string UserPhoto { get; set; } = "https://gravatar.com/avatar/27205e5c51cb03f862138b22bcb5dc20f94a342e744ff6df1b8dc8af3c865109?f=y\r\n";

        #endregion

        #region Constructor, LoadSettings

        public TemplatePageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
