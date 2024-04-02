using AndreasReitberger.Shared.FontIcons;
using System.Windows.Input;

namespace AndreasReitberger.Shared.ContentViews;

public partial class ProFeatureLockedContentView : ContentView
{
    #region Bindnings

    public static readonly BindableProperty ContentTextProperty = BindableProperty.Create(nameof(ContentText), typeof(string), typeof(ProFeatureLockedContentView), string.Empty);

    #endregion

    #region Properties
    public string ContentText
    {
        get => (string)GetValue(ContentTextProperty);
        set => SetValue(ContentTextProperty, value);
    }
    #endregion

    public ProFeatureLockedContentView()
    {
        InitializeComponent();
    }
}