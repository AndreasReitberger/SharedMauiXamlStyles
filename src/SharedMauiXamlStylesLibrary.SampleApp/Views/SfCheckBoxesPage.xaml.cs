using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfCheckBoxesPage : ContentPage
{
    public SfCheckBoxesPage(SfCheckBoxesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}