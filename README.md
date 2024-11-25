# About
This project is a shared style library for .NET MAUI applications containing recurring styles for
core controls and for the Syncfusion .NET MAUI controls (https://www.syncfusion.com/maui-controls).

This project bases on the SharedXamarinXamlStyles (https://github.com/AndreasReitberger/SharedXamarinXamlStyles)

# Support me
If you want to support me, you can order over following affilate links (I'll get a small share from your purchase from the corresponding store).

- Prusa: http://www.prusa3d.com/#a_aid=AndreasReitberger *
- Jake3D: https://tidd.ly/3x9JOBp * 
- Amazon: https://amzn.to/2Z8PrDu *
- Coinbase: https://advanced.coinbase.com/join/KTKSEBP * (10€ in BTC for you if you open an account)
- TradeRepublic: https://refnocode.trade.re/wfnk80zm * (10€ in stocks for you if you open an account)

(*) Affiliate link
Thank you very much for supporting me!

# Nugets
Get the latest version from nuget.org<br>

| Package                             | Nuget  | Downloads |
| ----------------------------------- |:-----:| -------:|
| SharedMauiXamlStyles                | [![NuGet](https://img.shields.io/nuget/v/SharedMauiXamlStylesLibrary.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/SharedMauiXamlStylesLibrary/)   | [![NuGet](https://img.shields.io/nuget/dt/SharedMauiXamlStylesLibrary.svg)](https://www.nuget.org/packages/SharedMauiXamlStylesLibrary)      |
| SharedMauiXamlStyles.Syncfusion     | [![NuGet](https://img.shields.io/nuget/v/SharedMauiXamlStylesLibrary.Syncfusion.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/SharedMauiXamlStylesLibrary.Syncfusion/)   | [![NuGet](https://img.shields.io/nuget/dt/SharedMauiXamlStylesLibrary.Syncfusion.svg)](https://www.nuget.org/packages/SharedMauiXamlStylesLibrary.Syncfusion)      |

# IMPORTANT CHANGE
Since putting all `FontKeys` in a `ResourceDictionary` leads to poor performance of the app, we moved all `FontKeys` to a static class instead.
For a migration guide, please see here:
https://github.com/AndreasReitberger/SharedMauiXamlStyles/wiki/Use-Icons-in-XAML-content#reference-icons

## Used fonts
All used fonts are available from the `SharedFonts.Fonts` property. 

```csharp
public class SharedFonts
    {
        #region Properties
        public static Dictionary<string, string> Fonts = new()
        {
            { "FontAwesome5Brands.otf", "FontAwesome5Brands" },
            { "FontAwesome5Regular.otf", "FontAwesome5Regular" },
            { "FontAwesome5Solid.otf", "FontAwesome5Solid" },
            { "materialdesignicons-webfont.ttf", "MaterialDesignIcons" },
            { "Montserrat-Bold.ttf", "MontserratBold" },
            { "Montserrat-Medium.ttf", "MontserratMedium" },
            { "Montserrat-Regular.ttf", "MontserratRegular" },
            { "Montserrat-SemiBold.ttf", "MontserratSemiBold" },
            { "UIFontIcons.ttf", "UIFontIcons" },
        };
        #endregion
    }
```

In order to register all shared fonts, add following function to the `MauiAppBuilder`.
Note! Don't forget to add the fonts also to your main MAUI app!
https://github.com/AndreasReitberger/SharedMauiXamlStyles/tree/main/source/SharedMauiXamlStylesLibrary/SharedMauiXamlStylesLibrary/Resources/Fonts

```csharp
public static MauiApp CreateMauiApp()
{
    MauiAppBuilder builder = MauiApp.CreateBuilder();
    builder
        .UseMauiApp<App>()
        .UseMauiCommunityToolkit()
        .ConfigureFonts(fonts =>
        {
            // Your custom used fonts
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        })
        // Initializes the library
        .InitializeSharedMauiStyles();  // <== Add this line
}
```

## Available control styles

| Control                             | Core  | Syncfusion |
| ----------------------------------- |:-----:| -------:|
| BoxView                             | ✅   | ❌      |
| Button                              | ✅   | ❌      |
| CheckBox                            | ✅   | ❌      |
| Editor                              | ✅   | ❌      |
| Entry                               | ✅   | ❌      |
| Frame                               | ✅   | ❌      |
| Grid                                | ✅   | ❌      |
| Label                               | ✅   | ❌      |
| Switch                              | ✅   | ❌      |
| StackPanel                          | ✅   | ❌      |
| RefreshView                         | ✅   | ❌      |
| SfTabView                           | ❌   | ✅      |
| SfListVirew                         | ❌   | ✅      |

## Migration from Xamarin.Forms (Syncfusion.XForm)
An overview of the corresponding MAUI controls if you migrate from `Syncfusion.XForm` to `Syncfusion.MAUI`.

| Syncfusion.XForms                   | MAUI (Core)        | Syncfusion.MAUI |
| ----------------------------------- |:------------------:| ---------------:|
| SfButton                            | Button             | ❌             |
| SfCheckBox                          | CheckBox           | ❌             |
| SfComboBox                          | Picker?!           | ❌             |
| SfBorder                            | Border             | ❌             |
| SfPullToRefresh                     | RefreshView        | ❌             |
| SfBusyIndicator                     | ActivityIndicator  | ❌             |
| SfSwitch                            | Switch             | ❌             |
| SfCircularGauge                     | ❌                 | SfRadialGauge  |
| SfBadgeView                         | ❌                 | SfBadgeView    |
| SfTabView                           | ❌                 | SfTabView      |
| SfListVirew                         | ❌                 | SfListVirew    |

### RoadMap
https://www.syncfusion.com/products/roadmap/maui-controls

List to be continued...

## Usage
This library combines all styles in the `DefaultTheme.xaml`, which can be merged into your `LightTheme.xaml` / `DarkTheme.xaml`.

```xaml
<ResourceDictionary
    x:Class="KlipperRemoteControl.Themes.LightTheme"
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    
    xmlns:shared="clr-namespace:AndreasReitberger.Shared;assembly=SharedMauiXamlStylesLibrary"
    >
    <ResourceDictionary.MergedDictionaries>
        <!-- Merge the DefaultTheme here -->
        <shared:DefaultTheme/>
    </ResourceDictionary.MergedDictionaries>

    <!-- Your style stuff -->
</ResourceDictionary>
```

Same applies to the DarkTheme.

# Style Keys
Due to a bug in MAUI (or Visual Studio), InteliSense doesn't suggest the style keys if using a nuget.
https://github.com/AndreasReitberger/SharedMauiXamlStyles/issues/43

## ActivityIndicator

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.ActivityIndicator.Default         | ActivityIndicator   | Core      |

## Border

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.Border.Default                    | Border              | Core      |
| Style.Core.Border.Profile                    | Border              | Core      |
| Style.Core.Border.CardView                   | Border              | Core      |
| Style.Core.Border.PanelCardView              | Border              | Core      |
| Style.Core.Border.MinimalPanelCardView       | Border              | Core      |
| Style.Core.Border.BrightMinimalPanelCardView | Border              | Core      |
| Style.Core.Border.Circle                     | Border              | Core      |
| Style.Core.Border.MenuSeparator              | Border              | Core      |

## BoxView

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.BoxView.Default                   | BoxView             | Core      |
| Style.Core.BoxView.Separator                 | BoxView             | Core      |

## Button

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.Button.Default                    | Button              | Core      |
| Style.Core.ImageButton.Default               | ImageButton         | Core      |
| Style.Core.Button.Icon                       | Button              | Core      |
| Style.Core.Button.IconPrimary                | Button              | Core      |
| Style.Core.Button.Icon.MaterialDesign        | Button              | Core      |
| Style.Core.Button.IconPrimary.MaterialDesign | Button              | Core      |
| Style.Core.Button.Link                       | Button              | Core      |
| Style.Core.Button.LinkRound                  | Button              | Core      |
| Style.Core.Button.IconRound                  | Button              | Core      |
| Style.Core.Button.RoundedLong                | Button              | Core      |
| Style.Core.Button.Setup                      | Button              | Core      |
| Style.Core.Button.Swipe                      | Button              | Core      |
| Style.Core.Button.IconRound.MaterialDesign   | Button              | Core      |
| Style.Core.Button.IconRound.EmergencyStop    | Button              | Core      |
| Style.Core.Button.LoginGoogle                | Button              | Core      |

## CheckBox

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.CheckBox.Default                  | CheckBox            | Core      |

## DatePicker

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.DatePicker.Default                | DatePicker          | Core      |

## Editor / BorderlessEditor

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.Editor.Default                    | Editor              | Core      |
| Style.Core.BorderlessEditor.Default          | BorderlessEditor    | Core      |

## Entry / BorderlessEntry

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.Entry.Default                     | Entry               | Core      |
| Style.Core.Entry.Numeric                     | Entry               | Core      |
| Style.Core.Entry.Password                    | Entry               | Core      |
| Style.Core.BorderlessEntry.Default           | BorderlessEntry     | Core      |
| Style.Core.BorderlessEntry.Numeric           | BorderlessEntry     | Core      |
| Style.Core.BorderlessEntry.Password          | BorderlessEntry     | Core      |

## Frame

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.Frame.Default                     | Frame               | Core      |
| Style.Core.Frame.ListViewItem                | Frame               | Core      |

## Grid / TapAnimationGrid

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.Grid.Default                      | Grid                | Core      |
| Style.Core.Grid.Settings                     | Grid                | Core      |
| Style.Core.Grid.Warning                      | Grid                | Core      |
| Style.Core.Grid.CriticalError                | Grid                | Core      |
| Style.Core.Grid.Panel                        | Grid                | Core      |
| Style.Core.Grid.Panel.Modal                  | Grid                | Core      |
| Style.Core.Grid.ShellTitleView               | Grid                | Core      |
| Style.Core.TapAnimationGrid.Default          | TapAnimationGrid    | Core      |

## IndicatorView

| Key                                          | TargetType          | Library   |
| ---------------------------------------------|:-------------------:| ---------:|
| Style.Core.IndicatorView.Default             | IndicatorView       | Core      |
 
## Label

| Key                                                    | TargetType          | Library   |
| -------------------------------------------------------|:-------------------:| ---------:|
| Style.Core.Label.Default                               | Label               | Core      |
| Style.Core.Label.Icon                                  | Label               | Core      |
| Style.Core.Label.Icon.MaterialDesign                   | Label               | Core      |
| Style.Core.Label.Icon.MaterialDesign.TextInputLayout   | Label               | Core      |
| Style.Core.Label.IconPrimary.MaterialDesign            | Label               | Core      |
| Style.Core.Label.Medium                                | Label               | Core      |
| Style.Core.Label.Small                                 | Label               | Core      |
| Style.Core.Label.VerySmall                             | Label               | Core      |
| Style.Core.Label.Setup                                 | Label               | Core      |
| Style.Core.Label.Link                                  | Label               | Core      |
| Style.Core.Label.Primary                               | Label               | Core      |
| Style.Core.Label.PrimaryDark                           | Label               | Core      |
| Style.Core.Label.Warning                               | Label               | Core      |
| Style.Core.Label.Error                                 | Label               | Core      |
| Style.Core.Label.Shell                                 | Label               | Core      |
| Style.Core.Label.Settings                              | Label               | Core      |
| Style.Core.Label.SettingsSmall                         | Label               | Core      |
| Style.Core.Label.Headline                              | Label               | Core      |
| Style.Core.Label.HeadlinePrimary                       | Label               | Core      |
| Style.Core.Label.HeadlinePrimaryDark                   | Label               | Core      |
| Style.Core.Label.TitleView                             | Label               | Core      |
| Style.Core.Label.IconSwipe                             | Label               | Core      |
| Style.Core.Label.IconSwipe.MaterialDesign              | Label               | Core      |
| Style.Core.Label.Option                                | Label               | Core      |
| Style.Core.Label.GroupingHeader                        | Label               | Core      |
| Style.Core.Span.IconTiny.MaterialDesign                | Label               | Core      |
| Style.Core.Span.Icon.MaterialDesign                    | Span                | Core      |
| Style.Core.Span.Icon                                   | Span                | Core      |

## ListView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.ListView.Default            | ListView            | Core      |

## Page

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Page.Default                | Page                | Core      |
| Style.Core.NavigationPage.Default      | NavigationPage      | Core      |
| Style.Core.TabbedPage.Default          | TabbedPage          | Core      |
| Style.Core.ContentPage.Default         | ContentPage         | Core      |
| Style.Core.ContentPage.Modal           | ContentPage         | Core      |
| Style.Core.ContentPage.Settings        | ContentPage         | Core      |

## Picker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Picker.Default              | Picker              | Core      |

## ProgressBar

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.ProgressBar.Default         | ProgressBar         | Core      |

## RadioButton

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.RadioButton.Default         | RadioButton         | Core      |

## RefreshView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.RefreshView.Default         | RefreshView         | Core      |

## SearchBar

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.SearchBar.Default           | SearchBar           | Core      |

## SearchHandler

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.SearchHandler.Default       | SearchHandler       | Core      |

## Shell

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Shell.Default               | Shell               | Core      |
| Style.Core.FlyoutItem.Default          | FlyoutItem          | Core      |

## Slider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSliderStyle                     | Slider              | Core      |

## StackLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.StackLayout.Header          | StackLayout         | Core      |
| Style.Core.StackLayout.Modal           | StackLayout         | Core      |
| Style.Core.VerticalStackLayout.Header  | VerticalStackLayout | Core      |
| Style.Core.VerticalStackLayout.Modal   | VerticalStackLayout | Core      |
| Style.Core.HorizontalStackLayout.Header| HorizontalStackLayout | Core   |
| Style.Core.HorizontalStackLayout.Modal | HorizontalStackLayout | Core   |

## SwipeItem

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.SwipeItem.Default           | SwipeItem           | Core      |

## Switch

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Switch.Default              | Switch              | Core      |

## TimePicker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.TimePicker.Default          | TimePicker          | Core      |

## SfAccordion

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfAccordion.Default   | SfAccordion         | Syncfusion|
| Style.Syncfusion.AccordionItem.Default | AccordionItem       | Syncfusion|

## SfAutocomplete

| Key                                                 | TargetType             | Library   |
| ----------------------------------------------------|:----------------------:| ---------:|
| Style.Syncfusion.SfAutocomplete.Default             | SfAutocomplete         | Syncfusion|
| Style.Syncfusion.MultiSelectAutoComplete.Default    | MultiSelectAutoComplete| Syncfusion|

## SfBadgeView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfBadgeView.Default   | SfBadgeView         | Syncfusion|
| Style.Syncfusion.SfBadgeView.Hyperlink | SfBadgeView         | Syncfusion|

## SfBusyIndicator

| Key                                      | TargetType          | Library   |
| -----------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfBusyIndicator.Default | SfBusyIndicator     | Syncfusion|

## SfCartesianChart

| Key                                                | TargetType          | Library   |
| ---------------------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfCartesianChart.Default          | SfCartesianChart    | Syncfusion|
| Style.Syncfusion.ChartLineStyle.Default.Major      | ChartAxisLabelStyle | Syncfusion|
| Style.Syncfusion.ChartLineStyle.Default.AxisChart  | ChartLineStyle      | Syncfusion|
| Style.Syncfusion.ChartLineStyle.Default.Minor      | ChartLineStyle      | Syncfusion|
| Style.Syncfusion.ChartAxisTickStyle.Default.Major  | ChartLineStyle      | Syncfusion|

## SfChip

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfChip.Default        | SfChip              | Syncfusion|
| Style.Syncfusion.SfChip.ColorSelection | SfChip              | Syncfusion|
| Style.Syncfusion.SfChipGroup.Default   | SfChipGroup         | Syncfusion|

## SfComboBox

| Key                                           | TargetType          | Library   |
| ----------------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfComboBox.Default           | SfComboBox          | Syncfusion|
| Style.Syncfusion.MultiSelectComboBox.Default  | MultiSelectComboBox | Syncfusion|

## SfExpander

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfExpander.Default    | SfExpander          | Syncfusion|

## SfListView

| Key                                           | TargetType          | Library   |
| ----------------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfListView.Default           | SfListView          | Syncfusion|
| Style.Syncfusion.SfListView.Swipe.DeleteEdit  | SfListView          | Syncfusion|

## SfMaskedEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfMaskedEntry.Default | SfMaskedEntry       | Syncfusion|

## SfNumericEntry

| Key                                      | TargetType          | Library   |
| -----------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfNumericEntry.Default  | SfNumericEntry      | Syncfusion|
| Style.Syncfusion.SfNumericEntry.Currency | SfNumericEntry      | Syncfusion|
| Style.Syncfusion.SfNumericEntry.Percent  | SfNumericEntry      | Syncfusion|

## SfPicker

| Key                                      | TargetType          | Library   |
| -----------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfPicker.Default        | SfPicker            | Syncfusion|
| Style.Syncfusion.SfDateTimePicker.Default| SfDateTimePicker    | Syncfusion|

## SfRadialGauge

| Key                                       | TargetType          | Library   |
| ------------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfRadialGauge.Default    | SfRadialGauge       | Syncfusion|
| Style.Syncfusion.RadialLineStyle.Default  | RadialLineStyle     | Syncfusion|

## SfRangeSlider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfRangeSlider.Default | SfRangeSlider       | Syncfusion|

## SfRating

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfRating.Default      | SfRating            | Syncfusion|

## SfSlider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfSlider.Default      | SfSlider            | Syncfusion|
| Style.Syncfusion.SfSlider.Primray      | SfSlider            | Syncfusion|
| Style.Syncfusion.SfSlider.Percent      | SfSlider            | Syncfusion|

## SfTabView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfTabView.Default     | SfTabView           | Syncfusion|
| Style.Syncfusion.SfTabItem.Default     | SfTabItem           | Syncfusion|

## SfTextInputLayout

| Key                                        | TargetType          | Library   |
| -------------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfTextInputLayout.Default | SfTextInputLayout   | Syncfusion|

# Workarounds

1. There is a bug with the static `FontSizes` provided by MAUI. So the library uses numeric `FontSizes` till this is fixed
Ref: https://github.com/dotnet/maui/issues/21074

- Default: 11 (for reference)
- Body: 11
- Small: 9
- Micro: 7
- Medium: 13
 
# Licenses & Thirdparty
This project uses thirdparty fonts. All licenses can be found in the project folder under Licenses -> LicenseFiles.
It's mandatory to also add those licenses to your final App. In this case you can use the LicenseManager class to get a List of all
used libraries and their licenses.
https://github.com/AndreasReitberger/SharedMauiXamlStyles/tree/main/source/SharedMauiXamlStylesLibrary/SharedMauiXamlStylesLibrary/Licenses/LicenseFiles
