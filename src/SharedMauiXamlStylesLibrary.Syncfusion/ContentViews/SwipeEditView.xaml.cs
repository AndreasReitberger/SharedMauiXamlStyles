namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class SwipeEditView : ContentView
{
    #region Bindings

    public static readonly BindableProperty EditCommandProperty = BindableProperty.Create(nameof(EditCommand), typeof(Command), typeof(SwipeEditView), null);
    public static readonly BindableProperty EditCommandParameterProperty = BindableProperty.Create(nameof(EditCommandParameter), typeof(object), typeof(SwipeEditView), null);

    #endregion

    #region Properties

    public string EditCommand
    {
        get => (string)GetValue(EditCommandProperty);
        set => SetValue(EditCommandProperty, value);
    }
    public object EditCommandParameter
    {
        get => GetValue(EditCommandParameterProperty);
        set => SetValue(EditCommandParameterProperty, value);
    }
    #endregion

    public SwipeEditView()
    {
        InitializeComponent();
    }
}