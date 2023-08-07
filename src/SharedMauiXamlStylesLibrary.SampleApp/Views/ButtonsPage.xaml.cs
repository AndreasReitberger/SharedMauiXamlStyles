using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class ButtonsPage : ContentPage
{
    public ButtonsPage(ButtonsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}