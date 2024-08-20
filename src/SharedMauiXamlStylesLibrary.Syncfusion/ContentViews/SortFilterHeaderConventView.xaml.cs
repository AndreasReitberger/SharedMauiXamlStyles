using System.Windows.Input;
using AndreasReitberger.Shared.Syncfusion.FontIcons;

namespace AndreasReitberger.Shared.Syncfusion.ContentViews;

[Obsolete("Use the view from `AndreasReitberger.Shared.ContentViews` instead")]
public partial class SortFilterHeaderConventView : ContentView
{
    #region Bindings

    public static readonly BindableProperty IsFilteredProperty = BindableProperty.Create(nameof(IsFiltered), typeof(bool), typeof(SortFilterHeaderConventView), false);
    public static readonly BindableProperty ShowFilterButtonProperty = BindableProperty.Create(nameof(ShowFilterButton), typeof(bool), typeof(SortFilterHeaderConventView), true);

    public static readonly BindableProperty ButtonIconFontFamilyProperty = BindableProperty.Create(nameof(ButtonIconFontFamily), typeof(string), typeof(SortFilterHeaderConventView), "UIFontIcons");
    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(SortFilterHeaderConventView), null);

    public static readonly BindableProperty SortButtonTextProperty = BindableProperty.Create(nameof(SortButtonText), typeof(string), typeof(SortFilterHeaderConventView), string.Empty);
    public static readonly BindableProperty FilterButtonTextProperty = BindableProperty.Create(nameof(FilterButtonText), typeof(string), typeof(SortFilterHeaderConventView), string.Empty);

    public static readonly BindableProperty SortButtonIconTextProperty = BindableProperty.Create(nameof(SortButtonIconText), typeof(string), typeof(SortFilterHeaderConventView), SyncfusionIcons.Sort);
    public static readonly BindableProperty FilterButtonIconTextProperty = BindableProperty.Create(nameof(FilterButtonIconText), typeof(string), typeof(SortFilterHeaderConventView), SyncfusionIcons.Filter);
    public static readonly BindableProperty ClearButtonIconTextProperty = BindableProperty.Create(nameof(ClearButtonIconText), typeof(string), typeof(SortFilterHeaderConventView), SyncfusionIcons.Close);

    public static readonly BindableProperty SortButtonCommandProperty = BindableProperty.Create(nameof(SortButtonCommand), typeof(ICommand), typeof(SortFilterHeaderConventView), null);
    public static readonly BindableProperty FilterButtonCommandProperty = BindableProperty.Create(nameof(FilterButtonCommand), typeof(ICommand), typeof(SortFilterHeaderConventView), null);
    public static readonly BindableProperty ClearButtonCommandProperty = BindableProperty.Create(nameof(ClearButtonCommand), typeof(ICommand), typeof(SortFilterHeaderConventView), null);

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
    #endregion

    public SortFilterHeaderConventView()
    {
        InitializeComponent();
    }
}