namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class AccountConventView : ContentView
{
    #region Bindings

    public static readonly BindableProperty UsernameTextProperty = BindableProperty.Create(nameof(UsernameText), typeof(string), typeof(TitleViewAccountConventView), string.Empty);
    public static readonly BindableProperty UserImageProperty = BindableProperty.Create(nameof(UserImage), typeof(ImageSource), typeof(TitleViewAccountConventView), null);

    #endregion

    #region Properties

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

    #endregion

    public AccountConventView()
    {
        InitializeComponent();
    }
}