using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfTextInputLayoutsPage : ContentPage
{
    public SfTextInputLayoutsPage(SfTextInputLayoutsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}