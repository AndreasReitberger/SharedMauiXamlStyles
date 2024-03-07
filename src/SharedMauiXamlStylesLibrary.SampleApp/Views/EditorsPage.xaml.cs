using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class EditorsPage : ContentPage
{
    public EditorsPage(EditorsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}