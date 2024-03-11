using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class AccordionsPage : ContentPage
{
    public AccordionsPage(AccordionsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}