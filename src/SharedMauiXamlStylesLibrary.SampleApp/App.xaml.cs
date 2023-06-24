using Syncfusion.Licensing;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public partial class App : Application
    {
        readonly string SyncfusionKey = "";

        public App()
        {
            SyncfusionLicenseProvider.RegisterLicense(SyncfusionKey);

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}