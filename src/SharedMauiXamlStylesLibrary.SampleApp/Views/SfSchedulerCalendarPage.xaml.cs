using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfSchedulerCalendarPage : ContentPage
{
    public SfSchedulerCalendarPage(SfSchedulerCalendarPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}