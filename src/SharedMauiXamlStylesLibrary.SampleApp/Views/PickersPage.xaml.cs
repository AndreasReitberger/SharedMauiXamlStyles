using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class PickersPage : ContentPage
{
    public PickersPage(PickersPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}