using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class BordersPage : ContentPage
{
    public BordersPage(BordersPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}