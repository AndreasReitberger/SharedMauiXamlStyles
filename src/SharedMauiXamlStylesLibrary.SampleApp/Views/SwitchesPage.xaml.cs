using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SwitchesPage : ContentPage
{
    public SwitchesPage(SwitchesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}