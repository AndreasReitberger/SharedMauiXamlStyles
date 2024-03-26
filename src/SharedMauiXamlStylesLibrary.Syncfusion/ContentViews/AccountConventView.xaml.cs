namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

public partial class AccountConventView : ContentView
{
    #region Bindings

    public static readonly BindableProperty UsernameTextProperty = BindableProperty.Create(nameof(UsernameText), typeof(string), typeof(TitleViewAccountConventView), string.Empty);
    public static readonly BindableProperty UserImageProperty = BindableProperty.Create(nameof(UserImage), typeof(ImageSource), typeof(TitleViewAccountConventView), null);
    
    public static readonly BindableProperty IsSyncingProperty = BindableProperty.Create(nameof(IsSyncing), typeof(bool), typeof(TitleViewAccountConventView), false);
    public static readonly BindableProperty IsSyncingTextProperty = BindableProperty.Create(nameof(IsSyncingText), typeof(string), typeof(TitleViewAccountConventView), string.Empty);

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

    public AccountConventView()
    {
        InitializeComponent();
    }
}