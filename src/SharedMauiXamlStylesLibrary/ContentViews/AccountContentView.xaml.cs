namespace AndreasReitberger.Shared.ContentViews;

public partial class AccountContentView : ContentView
{
    #region Bindings

    public static readonly BindableProperty UsernameTextProperty = BindableProperty.Create(nameof(UsernameText), typeof(string), typeof(AccountContentView), string.Empty);
    public static readonly BindableProperty UserImageProperty = BindableProperty.Create(nameof(UserImage), typeof(ImageSource), typeof(AccountContentView), null);

    public static readonly BindableProperty IsSyncingProperty = BindableProperty.Create(nameof(IsSyncing), typeof(bool), typeof(AccountContentView), false);
    public static readonly BindableProperty IsSyncingTextProperty = BindableProperty.Create(nameof(IsSyncingText), typeof(string), typeof(AccountContentView), string.Empty);

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
    public bool IsSyncing
    {
        get => (bool)GetValue(IsSyncingProperty);
        set => SetValue(IsSyncingProperty, value);
    }
    public string IsSyncingText
    {
        get => (string)GetValue(IsSyncingTextProperty);
        set => SetValue(IsSyncingTextProperty, value);
    }

    #endregion

    public AccountContentView()
    {
        InitializeComponent();
    }
}