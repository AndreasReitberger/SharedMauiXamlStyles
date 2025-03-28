namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class SwipePrint3dView : ContentView
{
    #region Bindings

    public static readonly BindableProperty PrintCommandProperty = BindableProperty.Create(nameof(PrintCommand), typeof(Command), typeof(SwipePrint3dView), null);
    public static readonly BindableProperty PrintCommandParameterProperty = BindableProperty.Create(nameof(PrintCommandParameter), typeof(object), typeof(SwipePrint3dView), null);

    #endregion

    #region Properties

    public string PrintCommand
    {
        get => (string)GetValue(PrintCommandProperty);
        set => SetValue(PrintCommandProperty, value);
    }
    public object PrintCommandParameter
    {
        get => GetValue(PrintCommandParameterProperty);
        set => SetValue(PrintCommandParameterProperty, value);
    }
    #endregion

    public SwipePrint3dView()
    {
        InitializeComponent();
    }
}