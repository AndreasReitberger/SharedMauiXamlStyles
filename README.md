# About
This project is a shared style library for .NET MAUI applications containing recurring styles for
core controls and for the Syncfusion .NET MAUI controls (https://www.syncfusion.com/maui-controls).

This project bases on the SharedXamarinXamlStyles (https://github.com/AndreasReitberger/SharedXamarinXamlStyles)

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

| Syncfusion.XForms                   | MAUI (Core)  | Syncfusion.MAUI |
| ----------------------------------- |:------------:| ---------------:|
| SfButton                            | Button       | ❌             |
| SfCheckBox                          | CheckBox     | ❌             |
| SfBadgeView                         | ❌           | SfBadgeView    |
| SfTabView                           | ❌           | SfTabView      |
| SfListVirew                         | ❌           | SfListVirew    |

## Usage
This library combines all styles in the `DefaultTheme.xaml`, which can be merged into your `LightTheme.xaml` / `DarkTheme.xaml`.
