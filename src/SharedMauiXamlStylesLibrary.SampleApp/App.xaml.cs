using Syncfusion.Licensing;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public partial class App : Application
    {
        readonly string SyncfusionKey = "";

        public App(IServiceProvider serviceProvider)
        {
            SyncfusionLicenseProvider.RegisterLicense(SyncfusionKey);

            InitializeComponent();

            // Workaroung: https://github.com/dotnet/maui/issues/11485#issuecomment-1416689085
            MainPage = serviceProvider.GetRequiredService<AppShell>();
        }
    }
}