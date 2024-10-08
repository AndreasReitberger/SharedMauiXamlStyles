using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class LanguagesPage : ContentPage
{
    public LanguagesPage(LanguagesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}