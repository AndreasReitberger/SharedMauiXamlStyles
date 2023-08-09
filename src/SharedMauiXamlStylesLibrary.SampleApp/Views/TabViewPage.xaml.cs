using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class TabViewPage : ContentPage
{
    public TabViewPage(TabViewPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}