using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class LabelsPage : ContentPage
{
    public LabelsPage(LablesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}