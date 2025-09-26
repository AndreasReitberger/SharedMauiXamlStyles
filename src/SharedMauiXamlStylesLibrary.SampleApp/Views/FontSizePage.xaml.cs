using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class FontSizePage : ContentPage
{
    public FontSizePage(LablesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}