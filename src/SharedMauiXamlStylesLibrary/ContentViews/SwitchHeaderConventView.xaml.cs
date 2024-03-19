using AndreasReitberger.Shared.FontIcons;
using System.Windows.Input;

namespace AndreasReitberger.Shared.ContentViews;

public partial class SwitchHeaderConventView : ContentView
{
    #region Bindings

    public static readonly BindableProperty ButtonIconFontFamilyProperty = BindableProperty.Create(nameof(ButtonIconFontFamily), typeof(string), typeof(SwitchHeaderConventView), "MaterialDesignIcons");

    public static readonly BindableProperty BackButtonTextProperty = BindableProperty.Create(nameof(BackButtonText), typeof(string), typeof(SwitchHeaderConventView), string.Empty);
    public static readonly BindableProperty NextButtonTextProperty = BindableProperty.Create(nameof(NextButtonText), typeof(string), typeof(SwitchHeaderConventView), string.Empty);

    public static readonly BindableProperty TitleLabelTextProperty = BindableProperty.Create(nameof(TitleLabelText), typeof(string), typeof(SwitchHeaderConventView), null);
    public static readonly BindableProperty TitleLabelFormattedStringProperty = BindableProperty.Create(nameof(TitleLabelFormattedString), typeof(FormattedString), typeof(SwitchHeaderConventView), null);

    public static readonly BindableProperty BackButtonIconTextProperty = BindableProperty.Create(nameof(BackButtonIconText), typeof(string), typeof(SwitchHeaderConventView), MaterialIcons.Filter);
    public static readonly BindableProperty NextButtonIconTextProperty = BindableProperty.Create(nameof(NextButtonIconText), typeof(string), typeof(SwitchHeaderConventView), MaterialIcons.Sort);

    public static readonly BindableProperty BackButtonCommandProperty = BindableProperty.Create(nameof(BackButtonCommand), typeof(ICommand), typeof(SwitchHeaderConventView), null);
    public static readonly BindableProperty NextButtonCommandProperty = BindableProperty.Create(nameof(NextButtonCommand), typeof(ICommand), typeof(SwitchHeaderConventView), null);

    #endregion

    #region Properties
    public string BackButtonText
    {
        get => (string)GetValue(BackButtonTextProperty);
        set => SetValue(BackButtonTextProperty, value);
    }
    public string NextButtonText
    {
        get => (string)GetValue(NextButtonTextProperty);
        set => SetValue(NextButtonTextProperty, value);
    }
    public string TitleLabelText
    {
        get => (string)GetValue(TitleLabelTextProperty);
        set => SetValue(TitleLabelTextProperty, value);
    }
    public FormattedString TitleLabelFormattedString
    {
        get => (FormattedString)GetValue(TitleLabelFormattedStringProperty);
        set => SetValue(TitleLabelFormattedStringProperty, value);
    }

    public string NextButtonIconText
    {
        get => (string)GetValue(NextButtonIconTextProperty);
        set => SetValue(NextButtonIconTextProperty, value);
    }
    public string BackButtonIconText
    {
        get => (string)GetValue(BackButtonIconTextProperty);
        set => SetValue(BackButtonIconTextProperty, value);
    }

    public string ButtonIconFontFamily
    {
        get => (string)GetValue(ButtonIconFontFamilyProperty);
        set => SetValue(ButtonIconFontFamilyProperty, value);
    }

    public ICommand BackButtonCommand
    {
        get => (ICommand)GetValue(BackButtonCommandProperty);
        set => SetValue(BackButtonCommandProperty, value);
    }
    public ICommand NextButtonCommand
    {
        get => (ICommand)GetValue(NextButtonCommandProperty);
        set => SetValue(NextButtonCommandProperty, value);
    }
    #endregion

    public SwitchHeaderConventView()
    {
        InitializeComponent();
    }
}