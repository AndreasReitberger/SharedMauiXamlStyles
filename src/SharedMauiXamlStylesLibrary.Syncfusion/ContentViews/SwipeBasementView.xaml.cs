namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class SwipeBasementView : ContentView
{
    #region Bindings

    public static readonly BindableProperty IconTextProperty = BindableProperty.Create(nameof(IconText), typeof(string), typeof(AccountConventView), string.Empty);
    public static readonly BindableProperty IconFontBrushProperty = BindableProperty.Create(nameof(IconFontBrush), typeof(Brush), typeof(SwipeBasementView), Brush.Black);
    public static readonly BindableProperty IconFontFamilyProperty = BindableProperty.Create(nameof(IconFontFamily), typeof(string), typeof(SwipeBasementView), "MaterialDesignIcons");

    public static readonly BindableProperty SwipeCommandProperty = BindableProperty.Create(nameof(SwipeCommand), typeof(Command), typeof(SwipeBasementView), null);
    public static readonly BindableProperty SwipeCommandParameterProperty = BindableProperty.Create(nameof(SwipeCommandParameter), typeof(object), typeof(SwipeBasementView), null);

    #endregion

    #region Properties

    public string IconText
    {
        get => (string)GetValue(IconTextProperty);
        set => SetValue(IconTextProperty, value);
    }
    public string IconFontFamily
    {
        get => (string)GetValue(IconFontFamilyProperty);
        set => SetValue(IconFontFamilyProperty, value);
    }
    public Brush IconFontBrush
    {
        get => (Brush)GetValue(IconFontBrushProperty);
        set => SetValue(IconFontBrushProperty, value);
    }

    public string SwipeCommand
    {
        get => (string)GetValue(SwipeCommandProperty);
        set => SetValue(SwipeCommandProperty, value);
    }
    public object SwipeCommandParameter
    {
        get => GetValue(SwipeCommandParameterProperty);
        set => SetValue(SwipeCommandParameterProperty, value);
    }
    #endregion

    public SwipeBasementView()
    {
        InitializeComponent();
    }
}