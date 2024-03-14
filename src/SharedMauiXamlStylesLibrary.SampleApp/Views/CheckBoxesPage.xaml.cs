using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class CheckBoxesPage : ContentPage
{
    public CheckBoxesPage(CheckBoxesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}