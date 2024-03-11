using SharedMauiXamlStylesLibrary.SampleApp.Utilities;
using Syncfusion.Licensing;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            SecretAppSetting secrets = SecretAppSettingReader.ReadSection<SecretAppSetting>("ExampleApp");
            if (secrets is not null)
            {
                SyncfusionLicenseProvider.RegisterLicense(secrets.SyncfusionApiKey);
            }
            InitializeComponent();

            // Workaroung: https://github.com/dotnet/maui/issues/11485#issuecomment-1416689085
            MainPage = serviceProvider.GetRequiredService<AppShell>();
        }
    }
}