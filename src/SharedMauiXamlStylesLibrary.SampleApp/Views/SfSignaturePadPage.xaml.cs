using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfSignaturePadPage : ContentPage
{
    public SfSignaturePadPage(SfSignaturePadPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}