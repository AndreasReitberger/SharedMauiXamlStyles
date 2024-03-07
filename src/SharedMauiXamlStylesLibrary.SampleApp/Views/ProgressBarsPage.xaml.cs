using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class ProgressBarsPage : ContentPage
{
    public ProgressBarsPage(ProgressBarsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}