using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfChatPage : ContentPage
{
    public SfChatPage(SfChatPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}