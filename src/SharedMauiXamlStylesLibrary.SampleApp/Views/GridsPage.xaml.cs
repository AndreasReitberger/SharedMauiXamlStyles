using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class GridsPage : ContentPage
{
    public GridsPage(GridsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}