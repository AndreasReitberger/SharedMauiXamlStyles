namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class SwipeDeleteView : ContentView
{
    #region Bindings

    public static readonly BindableProperty DeleteCommandProperty = BindableProperty.Create(nameof(DeleteCommand), typeof(Command), typeof(SwipeDeleteView), null);
    public static readonly BindableProperty DeleteCommandParameterProperty = BindableProperty.Create(nameof(DeleteCommandParameter), typeof(object), typeof(SwipeDeleteView), null);

    #endregion

    #region Properties

    public string DeleteCommand
    {
        get => (string)GetValue(DeleteCommandProperty);
        set => SetValue(DeleteCommandProperty, value);
    }
    public object DeleteCommandParameter
    {
        get => GetValue(DeleteCommandParameterProperty);
        set => SetValue(DeleteCommandParameterProperty, value);
    }
    #endregion

    public SwipeDeleteView()
    {
        InitializeComponent();
    }
}