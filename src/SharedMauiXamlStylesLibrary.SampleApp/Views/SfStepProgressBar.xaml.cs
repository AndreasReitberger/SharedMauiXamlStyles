using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class SfStepProgressBar : ContentPage
{
    public SfStepProgressBar(SfStepProgressBarViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        //Loaded += ((SfStepProgressBarViewModel)BindingContext).Pages_Loaded;
    }

    ~SfStepProgressBar()
    {
        //Loaded -= ((SfStepProgressBarViewModel)BindingContext).Pages_Loaded;
    }

    #region Methods
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            await ((SfStepProgressBarViewModel)BindingContext).OnAppearing();
        }
        catch (Exception) { }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        try
        {
            ((SfStepProgressBarViewModel)BindingContext).OnDisappearing();
        }
        catch (Exception) { }
    }
    #endregion
}