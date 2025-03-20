using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class TemplatePage : ContentPage
{
    public TemplatePage(TemplatePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}