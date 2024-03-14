using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfListViewPage : ContentPage
{
    public SfListViewPage(SfListViewPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}