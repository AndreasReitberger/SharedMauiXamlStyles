using AndreasReitberger.Shared.FontIcons;
using System.Windows.Input;

namespace AndreasReitberger.Shared.ContentViews;

public partial class SortFilterHeaderContentView : ContentView
{
    #region Bindings

    public static readonly BindableProperty IsFilteredProperty = BindableProperty.Create(nameof(IsFiltered), typeof(bool), typeof(SortFilterHeaderContentView), false);

    public static readonly BindableProperty ShowFilterButtonProperty = BindableProperty.Create(nameof(ShowFilterButton), typeof(bool), typeof(SortFilterHeaderContentView), true);

    public static readonly BindableProperty ButtonIconFontFamilyProperty = BindableProperty.Create(nameof(ButtonIconFontFamily), typeof(string), typeof(SortFilterHeaderContentView), "MaterialDesignIcons");
    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(SortFilterHeaderContentView), null);

    public static readonly BindableProperty SortButtonTextProperty = BindableProperty.Create(nameof(SortButtonText), typeof(string), typeof(SortFilterHeaderContentView), string.Empty);
    public static readonly BindableProperty FilterButtonTextProperty = BindableProperty.Create(nameof(FilterButtonText), typeof(string), typeof(SortFilterHeaderContentView), string.Empty);

    public static readonly BindableProperty SortButtonIconTextProperty = BindableProperty.Create(nameof(SortButtonIconText), typeof(string), typeof(SortFilterHeaderContentView), MaterialIcons.Sort);
    public static readonly BindableProperty FilterButtonIconTextProperty = BindableProperty.Create(nameof(FilterButtonIconText), typeof(string), typeof(SortFilterHeaderContentView), MaterialIcons.Filter);
    public static readonly BindableProperty ClearButtonIconTextProperty = BindableProperty.Create(nameof(ClearButtonIconText), typeof(string), typeof(SortFilterHeaderContentView), MaterialIcons.Close);

    public static readonly BindableProperty SortButtonCommandProperty = BindableProperty.Create(nameof(SortButtonCommand), typeof(ICommand), typeof(SortFilterHeaderContentView), null);
    public static readonly BindableProperty FilterButtonCommandProperty = BindableProperty.Create(nameof(FilterButtonCommand), typeof(ICommand), typeof(SortFilterHeaderContentView), null);
    public static readonly BindableProperty ClearButtonCommandProperty = BindableProperty.Create(nameof(ClearButtonCommand), typeof(ICommand), typeof(SortFilterHeaderContentView), null);

    public static readonly BindableProperty FilterButtonParameterProperty =
        BindableProperty.Create(nameof(FilterButtonParameter), typeof(object), typeof(SortFilterHeaderContentView), null);

    public static readonly BindableProperty SortButtonParameterProperty =
        BindableProperty.Create(nameof(SortButtonParameter), typeof(object), typeof(SortFilterHeaderContentView), null);

    public static readonly BindableProperty ClearButtonParameterProperty =
        BindableProperty.Create(nameof(ClearButtonParameter), typeof(object), typeof(SortFilterHeaderContentView), null);
    #endregion

    #region Properties
    public string SortButtonText
    {
        get => (string)GetValue(SortButtonTextProperty);
        set => SetValue(SortButtonTextProperty, value);
    }
    public string FilterButtonText
    {
        get => (string)GetValue(FilterButtonTextProperty);
        set => SetValue(FilterButtonTextProperty, value);
    }

    public string SortButtonIconText
    {
        get => (string)GetValue(SortButtonIconTextProperty);
        set => SetValue(SortButtonIconTextProperty, value);
    }
    public string FilterButtonIconText
    {
        get => (string)GetValue(FilterButtonIconTextProperty);
        set => SetValue(FilterButtonIconTextProperty, value);
    }
    public string ClearButtonIconText
    {
        get => (string)GetValue(ClearButtonIconTextProperty);
        set => SetValue(ClearButtonIconTextProperty, value);
    }

    public string ButtonIconFontFamily
    {
        get => (string)GetValue(ButtonIconFontFamilyProperty);
        set => SetValue(ButtonIconFontFamilyProperty, value);
    }
    public object CommandParameter
    {
        get => (object)GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public bool IsFiltered
    {
        get => (bool)GetValue(IsFilteredProperty);
        set => SetValue(IsFilteredProperty, value);
    }

    public bool ShowFilterButton
    {
        get => (bool)GetValue(ShowFilterButtonProperty);
        set => SetValue(ShowFilterButtonProperty, value);
    }

    public ICommand SortButtonCommand
    {
        get => (ICommand)GetValue(SortButtonCommandProperty);
        set => SetValue(SortButtonCommandProperty, value);
    }
    public ICommand FilterButtonCommand
    {
        get => (ICommand)GetValue(FilterButtonCommandProperty);
        set => SetValue(FilterButtonCommandProperty, value);
    }
    public ICommand ClearButtonCommand
    {
        get => (ICommand)GetValue(ClearButtonCommandProperty);
        set => SetValue(ClearButtonCommandProperty, value);
    }
    public object FilterButtonParameter
    {
        get { return GetValue(FilterButtonParameterProperty); }
        set { SetValue(FilterButtonParameterProperty, value); }
    }
    public object SortButtonParameter
    {
        get { return GetValue(SortButtonParameterProperty); }
        set { SetValue(SortButtonParameterProperty, value); }
    }
    public object ClearButtonParameter
    {
        get { return GetValue(ClearButtonParameterProperty); }
        set { SetValue(ClearButtonParameterProperty, value); }
    }
    #endregion

    public SortFilterHeaderContentView()
    {
        InitializeComponent();
    }
}