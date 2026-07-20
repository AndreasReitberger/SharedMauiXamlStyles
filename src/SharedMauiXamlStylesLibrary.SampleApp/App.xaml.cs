namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public partial class App : Application
    {
        public static IServiceProvider? ServiceProvider;

        public App(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
            InitializeComponent();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            AppShell? page = ServiceProvider?.GetRequiredService<AppShell>();
            return new Window(page ?? new AppShell());
        }
    }
}