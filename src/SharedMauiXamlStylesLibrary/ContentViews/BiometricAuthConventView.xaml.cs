using AndreasReitberger.Shared.FontIcons;
using System.Windows.Input;

namespace AndreasReitberger.Shared.ContentViews;

public partial class BiometricAuthConventView : ContentView
{
    #region Bindings

    public static readonly BindableProperty ButtonIconFontFamilyProperty = BindableProperty.Create(nameof(ButtonIconFontFamily), typeof(string), typeof(BiometricAuthConventView), "MaterialDesignIcons");

    public static readonly BindableProperty AuthButtonTextProperty = BindableProperty.Create(nameof(AuthButtonText), typeof(string), typeof(BiometricAuthConventView), string.Empty);
    public static readonly BindableProperty AuthedProperty = BindableProperty.Create(nameof(Authed), typeof(bool), typeof(BiometricAuthConventView), false);

    public static readonly BindableProperty TitleLabelTextProperty = BindableProperty.Create(nameof(TitleLabelText), typeof(string), typeof(BiometricAuthConventView), null);
    public static readonly BindableProperty TitleLabelFormattedStringProperty = BindableProperty.Create(nameof(TitleLabelFormattedString), typeof(FormattedString), typeof(BiometricAuthConventView), null);

    public static readonly BindableProperty AuthButtonIconTextProperty = BindableProperty.Create(nameof(AuthButtonIconText), typeof(string), typeof(BiometricAuthConventView), MaterialIcons.Filter);

    public static readonly BindableProperty AuthButtonCommandProperty = BindableProperty.Create(nameof(AuthButtonCommand), typeof(ICommand), typeof(BiometricAuthConventView), null);

    #endregion

    #region Properties
    public string AuthButtonText
    {
        get => (string)GetValue(AuthButtonTextProperty);
        set => SetValue(AuthButtonTextProperty, value);
    }
    public bool Authed
    {
        get => (bool)GetValue(AuthedProperty);
        set => SetValue(AuthedProperty, value);
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

    public string AuthButtonIconText
    {
        get => (string)GetValue(AuthButtonIconTextProperty);
        set => SetValue(AuthButtonIconTextProperty, value);
    }

    public string ButtonIconFontFamily
    {
        get => (string)GetValue(ButtonIconFontFamilyProperty);
        set => SetValue(ButtonIconFontFamilyProperty, value);
    }

    public ICommand AuthButtonCommand
    {
        get => (ICommand)GetValue(AuthButtonCommandProperty);
        set => SetValue(AuthButtonCommandProperty, value);
    }
    #endregion

    public BiometricAuthConventView()
    {
        InitializeComponent();
    }
}