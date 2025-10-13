using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfComboBoxesPage : ContentPage
{
    public SfComboBoxesPage(SfComboBoxesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}