using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfSegmentedControlPage : ContentPage
{
    public SfSegmentedControlPage(SfSegmentedControlPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}