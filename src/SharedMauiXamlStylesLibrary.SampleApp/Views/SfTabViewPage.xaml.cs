using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfTabViewPage : ContentPage
{
    public SfTabViewPage(SfTabViewPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}