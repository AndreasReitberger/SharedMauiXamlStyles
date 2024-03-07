using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class BoxViewsPage : ContentPage
{
    public BoxViewsPage(BoxViewsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}