using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class FramesPage : ContentPage
{
    public FramesPage(FramesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}