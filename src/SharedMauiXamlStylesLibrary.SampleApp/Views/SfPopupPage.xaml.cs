using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfPopupPage : ContentPage
{
    public SfPopupPage(SfPopupPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}