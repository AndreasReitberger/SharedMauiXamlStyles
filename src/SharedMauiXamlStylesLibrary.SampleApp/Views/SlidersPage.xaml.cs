using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SlidersPage : ContentPage
{
    public SlidersPage(SlidersPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}