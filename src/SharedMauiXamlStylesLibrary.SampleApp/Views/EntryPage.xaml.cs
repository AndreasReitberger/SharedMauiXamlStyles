using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class EntryPage : ContentPage
{
    public EntryPage(EntryPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}