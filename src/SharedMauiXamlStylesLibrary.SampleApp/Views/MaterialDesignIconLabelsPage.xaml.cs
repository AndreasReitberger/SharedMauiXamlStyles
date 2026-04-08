using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class MaterialDesignIconLabelsPage : ContentPage
{
    public MaterialDesignIconLabelsPage(IconLablesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = new IconLablesPageViewModel(viewModel.Dispatcher, viewModel.Provider, "MaterialDesignIconsOutlined");
    }
}