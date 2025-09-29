using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfShimmerPage : ContentPage
{
    public SfShimmerPage(SfShimmerPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        //Loaded += ((SfShimmerPageViewModel)BindingContext).Pages_Loaded;
    }

    ~SfShimmerPage()
    {
        //Loaded -= ((SfShimmerPageViewModel)BindingContext).Pages_Loaded;
    }

    #region Methods
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            await ((SfShimmerPageViewModel)BindingContext).OnAppearing();
        }
        catch (Exception) { }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        try
        {
            ((SfShimmerPageViewModel)BindingContext).OnDisappearing();
        }
        catch (Exception) { }
    }
    #endregion
}