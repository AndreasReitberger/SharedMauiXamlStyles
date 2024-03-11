using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class ComboBoxesPage : ContentPage
{
    public ComboBoxesPage(ComboBoxesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}