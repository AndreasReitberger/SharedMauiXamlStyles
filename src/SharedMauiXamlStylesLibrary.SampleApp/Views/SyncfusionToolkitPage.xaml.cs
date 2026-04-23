using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SyncfusionToolkitPage : ContentPage
{
    public SyncfusionToolkitPage(SyncfusionToolkitPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}