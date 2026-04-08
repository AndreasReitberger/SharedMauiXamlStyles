using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class TablerIconLabelsPage : ContentPage
{
    public TablerIconLabelsPage(IconLablesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = new IconLablesPageViewModel(viewModel.Dispatcher, viewModel.Provider, "TablerIconsRegular");
    }
}