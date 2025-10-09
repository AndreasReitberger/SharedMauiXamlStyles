using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfTreeMapPadPage : ContentPage
{
    public SfTreeMapPadPage(SfTreeMapPadPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}