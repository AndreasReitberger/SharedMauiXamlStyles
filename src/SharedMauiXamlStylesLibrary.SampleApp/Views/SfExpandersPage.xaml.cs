using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfExpandersPage : ContentPage
{
    public SfExpandersPage(SfExpandersPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}