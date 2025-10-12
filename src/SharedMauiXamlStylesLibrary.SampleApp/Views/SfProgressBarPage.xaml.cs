using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfProgressBarPage : ContentPage
{
    public SfProgressBarPage(SfProgressBarPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        //Loaded += ((SfProgressBarPageViewModel)BindingContext).Pages_Loaded;
    }

    ~SfProgressBarPage()
    {
        //Loaded -= ((SfProgressBarPageViewModel)BindingContext).Pages_Loaded;
    }

    #region Methods
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            await ((SfProgressBarPageViewModel)BindingContext).OnAppearing();
        }
        catch (Exception) { }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        try
        {
            ((SfProgressBarPageViewModel)BindingContext).OnDisappearing();
        }
        catch (Exception) { }
    }
    #endregion
}