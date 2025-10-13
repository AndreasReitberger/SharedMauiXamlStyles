using System.Windows.Input;

namespace AndreasReitberger.Shared.ContentViews;

public partial class TitleViewAccountContentView : ContentView
{
    #region Bindings

    public static readonly BindableProperty ButtonIconFontFamilyProperty = BindableProperty.Create(nameof(ButtonIconFontFamily), typeof(string), typeof(TitleViewAccountContentView), "MaterialDesignIcons");

    public static readonly BindableProperty IsLoggedInProperty = BindableProperty.Create(nameof(IsLoggedIn), typeof(bool), typeof(TitleViewAccountContentView), false);
    public static readonly BindableProperty HideAccountAreaProperty = BindableProperty.Create(nameof(HideAccountArea), typeof(bool), typeof(TitleViewAccountContentView), false);

    public static readonly BindableProperty AccountLabelTextProperty = BindableProperty.Create(nameof(AccountLabelText), typeof(string), typeof(TitleViewAccountContentView), null);
    public static readonly BindableProperty AccountLabelFormattedStringProperty = BindableProperty.Create(nameof(AccountLabelFormattedString), typeof(FormattedString), typeof(TitleViewAccountContentView), null, BindingMode.TwoWay);

    public static readonly BindableProperty AuthLabelTextProperty = BindableProperty.Create(nameof(AuthLabelText), typeof(string), typeof(TitleViewAccountContentView), null);
    public static readonly BindableProperty AuthLabelFormattedStringProperty = BindableProperty.Create(nameof(AuthLabelFormattedString), typeof(FormattedString), typeof(TitleViewAccountContentView), null);

    public static readonly BindableProperty UsernameTextProperty = BindableProperty.Create(nameof(UsernameText), typeof(string), typeof(TitleViewAccountContentView), string.Empty);
    public static readonly BindableProperty UserImageProperty = BindableProperty.Create(nameof(UserImage), typeof(ImageSource), typeof(TitleViewAccountContentView), null);

    public static readonly BindableProperty AccountButtonCommandProperty = BindableProperty.Create(nameof(AccountButtonCommand), typeof(ICommand), typeof(TitleViewAccountContentView), null);
    public static readonly BindableProperty AuthButtonCommandProperty = BindableProperty.Create(nameof(AccountButtonCommand), typeof(ICommand), typeof(TitleViewAccountContentView), null);

    #endregion

    #region Properties

    public bool HideAccountArea
    {
        get => (bool)GetValue(HideAccountAreaProperty);
        set => SetValue(HideAccountAreaProperty, value);
    }

    public bool IsLoggedIn
    {
        get => (bool)GetValue(IsLoggedInProperty);
        set => SetValue(IsLoggedInProperty, value);
    }

    public string AccountLabelText
    {
        get => (string)GetValue(AccountLabelTextProperty);
        set => SetValue(AccountLabelTextProperty, value);
    }
    public FormattedString AccountLabelFormattedString
    {
        get => (FormattedString)GetValue(AccountLabelFormattedStringProperty);
        set => SetValue(AccountLabelFormattedStringProperty, value);
    }
    public string AuthLabelText
    {
        get => (string)GetValue(AuthLabelTextProperty);
        set => SetValue(AuthLabelTextProperty, value);
    }
    public FormattedString AuthLabelFormattedString
    {
        get => (FormattedString)GetValue(AuthLabelFormattedStringProperty);
        set => SetValue(AuthLabelFormattedStringProperty, value);
    }

    public string UsernameText
    {
        get => (string)GetValue(UsernameTextProperty);
        set => SetValue(UsernameTextProperty, value);
    }
    public ImageSource UserImage
    {
        get => (ImageSource)GetValue(UserImageProperty);
        set => SetValue(UserImageProperty, value);
    }

    public string ButtonIconFontFamily
    {
        get => (string)GetValue(ButtonIconFontFamilyProperty);
        set => SetValue(ButtonIconFontFamilyProperty, value);
    }

    public ICommand AccountButtonCommand
    {
        get => (ICommand)GetValue(AccountButtonCommandProperty);
        set => SetValue(AccountButtonCommandProperty, value);
    }

    public ICommand AuthButtonCommand
    {
        get => (ICommand)GetValue(AuthButtonCommandProperty);
        set => SetValue(AuthButtonCommandProperty, value);
    }
    #endregion

    public TitleViewAccountContentView()
    {
        InitializeComponent();
    }
}