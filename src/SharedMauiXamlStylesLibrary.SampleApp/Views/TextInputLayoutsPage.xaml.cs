using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class TextInputLayoutsPage : ContentPage
{
    public TextInputLayoutsPage(TextInputLayoutsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}