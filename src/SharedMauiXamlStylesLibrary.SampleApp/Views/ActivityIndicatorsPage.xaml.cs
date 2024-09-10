using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class ActivityIndicatorsPage : ContentPage
{
    public ActivityIndicatorsPage(ActivityIndicatorsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}