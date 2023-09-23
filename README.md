# About
This project is a shared style library for .NET MAUI applications containing recurring styles for
core controls and for the Syncfusion .NET MAUI controls (https://www.syncfusion.com/maui-controls).

This project bases on the SharedXamarinXamlStyles (https://github.com/AndreasReitberger/SharedXamarinXamlStyles)

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

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultActivityIndicator               | ActivityIndicator   | Core      |

## Border

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| ProfileBorderStyle                     | Border              | Core      |
| CardViewBorderStyle                    | Border              | Core      |
| PanelCardViewBorderStyle               | Border              | Core      |
| MinimalPanelCardViewBorderStyle        | Border              | Core      |
| BrightMinimalPanelCardViewBorderStyle  | Border              | Core      |
| CircleBorderStyle                      | Border              | Core      |
| MenuSeparatorBorderStyle               | Border              | Core      |

## BoxView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| SeparatorStyle                         | BoxView             | Core      |

## Button

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultButtonStyle                     | Button              | Core      |
| ImageButton                            | Button              | Core      |
| IconButtonStyle                        | Button              | Core      |
| MaterialDesignIconButtonStyle          | Button              | Core      |
| PrimaryMaterialDesignIconButtonStyle   | Button              | Core      |
| LinkButtonStyle                        | Button              | Core      |
| LinkRoundButtonStyle                   | Button              | Core      |
| RoundIconButtonStyle                   | Button              | Core      |
| RoundedLongButtonStyle                 | Button              | Core      |
| SwipeTemplateBorderStyle               | Button              | Core      |
| SwipeTemplateButtonStyle               | Button              | Core      |
| RoundMaterialDesignIconButtonStyle     | Button              | Core      |
| RoundEmergencyStopIconButtonStyle      | Button              | Core      |
| GoogleLoginButtonStyle                 | Button              | Core      |

## CheckBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultCheckBoxStyle                   | CheckBox            | Core      |

## DatePicker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultDatePickerStyle                 | DatePicker          | Core      |

## Editor / BorderlessEditor

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultEditorStyle                     | Editor              | Core      |
| DefaultBorderlessEditorStyle           | BorderlessEditor    | Core      |

## Entry / BorderlessEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultEntryStyle                      | Entry               | Core      |
| NumericEntryStyle                      | Entry               | Core      |
| PasswordEntryStyle                     | Entry               | Core      |

## Frame

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultFrameStyle                      | Frame               | Core      |
| ListViewItemFrameStyle                 | Frame               | Core      |

## Grid / TapAnimationGrid

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultGridStyle                       | Grid                | Core      |
| DefaultSettingsGridStyle               | Grid                | Core      |
| WarningGridStyle                       | Grid                | Core      |
| CriticalErrorGridStyle                 | Grid                | Core      |
| DefaultPanelGridStyle                  | Grid                | Core      |
| ModalPanelGridStyle                    | Grid                | Core      |
| ShellTitleViewGridStyle                | Grid                | Core      |
| DefaultTapAnimationGridStyle           | TapAnimationGrid    | Core      |

## IndicatorView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultIndicatorViewStyle              | IndicatorView       | Core      |
 
## Label

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultLabelStyle                      | Label               | Core      |
| LabelStyle                             | Label               | Core      |
| IconLabelStyle                         | Label               | Core      |
| MaterialSettingsIconLabelStyle         | Label               | Core      |
| TextInputLayoutMaterialIconLabelStyle  | Label               | Core      |
| MaterialFontFamilyIconLabelStyle       | Label               | Core      |
| PrimaryMaterialFontFamilyIconLabelStyle| Label               | Core      |
| MediumLabelStyle                       | Label               | Core      |
| SmallLabelStyle                        | Label               | Core      |
| VerySmallLabelStyle                    | Label               | Core      |
| SetupLabelStyle                        | Label               | Core      |
| LinkLabelStyle                         | Label               | Core      |
| PrimaryLabelStyle                      | Label               | Core      |
| PrimaryDarkLabelStyle                  | Label               | Core      |
| WarningLabelStyle                      | Label               | Core      |
| ErrorLabelStyle                        | Label               | Core      |
| ShellLabelStyle                        | Label               | Core      |
| SettingsLabelStyle                     | Label               | Core      |
| SettingsSmallLabelStyle                | Label               | Core      |
| HeadlineLabelStyle                     | Label               | Core      |
| PrimaryHeadlineLabelStyle              | Label               | Core      |
| TitleViewHeadlineLabelStyle            | Label               | Core      |
| PrimaryDarkHeadlineLabelStyle          | Label               | Core      |
| SwipeTemplateButtonStyle               | Label               | Core      |
| OptionButtonLabelStyle                 | Label               | Core      |
| GroupingHeaderLabelStyle               | Label               | Core      |
| SwipeTemplateMaterialButtonStyle       | Label               | Core      |
| MaterialFontIconSpanStyle              | Label               | Core      |
| FontIconSpanStyle                      | Label               | Core      |
| MaterialFontFamilyIconSmallLabelStyle  | Label               | Core      |
| MaterialSwipeTemplateButtonStyle       | Label               | Core      |

## ListView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultListViewStyle                   | ListView            | Core      |

## Page

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultPageStyle                       | Page                | Core      |
| ModalPageStyle                         | Page                | Core      |
| SettingsPageStyle                      | Page                | Core      |

## Picker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultPickerStyle                     | Picker              | Core      |

## ProgressBar

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultProgressBarStyle                | ProgressBar         | Core      |

## RadioButton

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultRadioButtonStyle                | RadioButton         | Core      |

## RefreshView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultRefreshViewStyle                | RefreshView         | Core      |

## SearchBar

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSearchBarStyle                  | SearchBar           | Core      |

## SearchHandler

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSearchHandlerStyle              | SearchHandler       | Core      |

## Shadow

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultShadowStyle                     | Shadow              | Core      |
| CardViewShadowStyle                    | Shadow              | Core      |

## Shell

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| BaseStyle                              | Element             | Core      |
| DefaultShellStyle                      | Shell               | Core      |
| DefaultFlyoutItemStyle                 | FlyoutItem          | Core      |

## Slider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSliderStyle                     | Slider              | Core      |

## StackLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| StackLayoutHeaderStyle                 | StackLayout         | Core      |
| ModalInputPageStackLayoutStyle         | StackLayout         | Core      |
| VerticalStackLayoutHeaderStyle         | VerticalStackLayout | Core      |
| VerticalModalInputPageStackLayoutStyle | VerticalStackLayout | Core      |
| HorizontalStackLayoutHeaderStyle       | HorizontalStackLayout  | Core   |
| HorizontalModalInputPageStackLayoutStyle| HorizontalStackLayout | Core   |

## SwipeItem

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSwipeItemStyle                  | SwipeItem           | Core      |

## Switch

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSwitchStyle                     | Switch              | Core      |

## TimePicker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultTimePickerStyle                 | TimePicker          | Core      |

## SfAccordion

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultAccordionStyle                  | SfAccordion         | Syncfusion|
| DefaultAccordionItemStyle              | AccordionItem       | Syncfusion|

## SfAutocomplete

| Key                                    | TargetType             | Library   |
| ---------------------------------------|:----------------------:| ---------:|
| DefaultAutocompleteStyle               | SfAutocomplete         | Syncfusion|
| DefaultMultiSelectAutoCompleteStyle    | MultiSelectAutoComplete| Syncfusion|

## SfBadgeView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultBadgeViewStyle                  | SfBadgeView         | Syncfusion|
| HyperlinkBadgedViewStyle               | SfBadgeView         | Syncfusion|

## SfBusyIndicator

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultBusyIndicatorStyle              | SfBusyIndicator     | Syncfusion|

## SfCartesianChart

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| NumericOnlySfCartesianChartStyle       | SfCartesianChart    | Syncfusion|
| DefaultChartAxisLabelStyle             | ChartAxisLabelStyle | Syncfusion|
| DefaultMajorGridChartLineStyle         | ChartLineStyle      | Syncfusion|
| DefaultAxisChartLineStyle              | ChartLineStyle      | Syncfusion|
| DefaultMinorGridChartLineStyle         | ChartLineStyle      | Syncfusion|
| DefaultMajorChartAxisTickStyle         | ChartAxisTickStyle  | Syncfusion|

## SfChip

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultChipStyle                       | SfChip              | Syncfusion|
| ColorSelectionChipStyle                | SfChip              | Syncfusion|
| DefaultChipGroupStyle                  | SfChipGroup         | Syncfusion|

## SfComboBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultComboBoxStyle                   | SfComboBox          | Syncfusion|
| DefaultMultiSelectComboBox             | MultiSelectComboBox | Syncfusion|

## SfExpander

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultExpanderStyle                   | SfExpander          | Syncfusion|

## SfListView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfListViewStyle                 | SfListView          | Syncfusion|
| ListViewDeleteEditGestureSwipeableStyle| SfListView          | Syncfusion|

## SfMaskedEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultMaskedEntryStyle                | SfMaskedEntry       | Syncfusion|

## SfNumericEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfNumericEntryStyle             | SfNumericEntry      | Syncfusion|
| CurrencySfNumericEntryStyle            | SfNumericEntry      | Syncfusion|
| PercentageSfNumericEntryStyle          | SfNumericEntry      | Syncfusion|

## SfRadialGauge

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfRadialGaugeStyle              | SfRadialGauge       | Syncfusion|
| DefaultRadialLineStyle                 | RadialLineStyle     | Syncfusion|

## SfRangeSlider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfRangeSliderStyle              | SfRangeSlider       | Syncfusion|

## SfRating

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultRatingStyle                     | SfRating            | Syncfusion|

## SfSlider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfSliderStyle                   | SfSlider            | Syncfusion|
| PrimraySliderStyle                     | SfSlider            | Syncfusion|
| PercentageSliderStyle                  | SfSlider            | Syncfusion|

## SfTabView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfTabViewStyle                  | SfTabView           | Syncfusion|
| DefaultSfTabViewItemStyle              | SfTabItem           | Syncfusion|

## SfTextInputLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultTextInputLayoutStyle            | SfTextInputLayout   | Syncfusion|


# Licenses & Thirdparty
This project uses thirdparty fonts. All licenses can be found in the project folder under Licenses -> LicenseFiles.
It's mandatory to also add those licenses to your final App. In this case you can use the LicenseManager class to get a List of all
used libraries and their licenses.
https://github.com/AndreasReitberger/SharedMauiXamlStyles/tree/main/source/SharedMauiXamlStylesLibrary/SharedMauiXamlStylesLibrary/Licenses/LicenseFiles
