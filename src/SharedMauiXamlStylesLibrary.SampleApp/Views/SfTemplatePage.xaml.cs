using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfTemplatePage : ContentPage
{
    public SfTemplatePage(TemplatePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}