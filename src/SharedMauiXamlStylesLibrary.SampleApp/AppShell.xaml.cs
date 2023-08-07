using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;
using ServiceProvider = SharedMauiXamlStylesLibrary.SampleApp.Services.ServiceProvider;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new AppShellViewModel(Dispatcher, ServiceProvider.Current);
        }
    }
}