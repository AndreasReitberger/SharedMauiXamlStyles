using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfAccordionsPage : ContentPage
{
    public SfAccordionsPage(SfAccordionsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}