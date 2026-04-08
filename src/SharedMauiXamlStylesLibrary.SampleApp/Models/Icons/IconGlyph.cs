using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.Icons
{
    //Source: https://github.com/jfversluis/IconFont.Maui.MaterialDesignIcons/blob/8988b24377af7c03147314526f33f9251123e49e/samples/IconFont.Maui.MaterialDesignIcons.Sample/ViewModels/IconsViewModel.cs#L8
    public partial class IconGlyph : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        public partial string Glyph { get; set; }
        [ObservableProperty]
        public partial string Identifier { get; set; }
        [ObservableProperty]
        public partial string XamlIdentifier { get; set; }
        [ObservableProperty]
        public partial string FontFamily { get; set; }
        #endregion
    }
}
