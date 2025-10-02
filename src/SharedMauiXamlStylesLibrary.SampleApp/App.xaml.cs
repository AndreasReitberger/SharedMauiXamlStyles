using SharedMauiXamlStylesLibrary.SampleApp.Utilities;
using Syncfusion.Licensing;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public partial class App : Application
    {
        public static IServiceProvider? ServiceProvider;

        public App(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
            SecretAppSetting? secrets = SecretAppSettingReader.ReadSection<SecretAppSetting>("ExampleApp");
            if (secrets is not null)
            {
                SyncfusionLicenseProvider.RegisterLicense(secrets.SyncfusionApiKey);
            }
            InitializeComponent();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            AppShell? page = ServiceProvider?.GetRequiredService<AppShell>();
            return new Window(page ?? new AppShell());
        }
    }
}