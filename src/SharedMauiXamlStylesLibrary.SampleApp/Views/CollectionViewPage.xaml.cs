using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class CollectionViewPage : ContentPage
{
    public CollectionViewPage(CollectionViewPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}