namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class SwipeShowView : ContentView
{
    #region Bindings

    public static readonly BindableProperty ShowCommandProperty = BindableProperty.Create(nameof(ShowCommand), typeof(Command), typeof(SwipeShowView), null);
    public static readonly BindableProperty ShowCommandParameterProperty = BindableProperty.Create(nameof(ShowCommandParameter), typeof(object), typeof(SwipeShowView), null);

    #endregion

    #region Properties

    public string ShowCommand
    {
        get => (string)GetValue(ShowCommandProperty);
        set => SetValue(ShowCommandProperty, value);
    }
    public object ShowCommandParameter
    {
        get => GetValue(ShowCommandParameterProperty);
        set => SetValue(ShowCommandParameterProperty, value);
    }
    #endregion

    public SwipeShowView()
    {
        InitializeComponent();
    }
}