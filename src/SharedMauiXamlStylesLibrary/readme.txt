# Getting started
Open the `MauiProgramm.cs` file and add `InitializeSharedMauiStyles()`

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

To add the Styles and Colors to your app theme, you can merge the `ResourceDictionary` at your App.xaml page.

```xaml
    <ResourceDictionary.MergedDictionaries>
        <!-- your own stuff -->
        <ResourceDictionary Source="/Themes/DefaultColors.xaml" />

        <!-- Library componentes -->
        <shared:Fonts />
        <shared:Styles />
        <shared:Templates />
        <!-- or the whole theme -->
        <shared:DefaultTheme/>
    </ResourceDictionary.MergedDictionaries>
```
For further instructions or issues, please visit the project page on github.
https://github.com/AndreasReitberger/SharedMauiXamlStyles

# Important update notice
Since 1.1.0, we moved all Syncfusion related stuff into its own project and nuget package.
Search for => "SharedMauiXamlStylesLibrary.Syncfusion"

Since 1.0.9, we changed the location for the `FontIconKeys`.
In order to use the library, you need to migrate to use the new `FontIconKeys` instead.

Please follow the guide below.

# Migration Guide

https://github.com/AndreasReitberger/SharedMauiXamlStyles/wiki/Use-Icons-in-XAML-content#reference-icons

# Icons reference

In each XAML content, where you want to use the icons, please reference following namespace.

```xaml
xmlns:icons="clr-namespace:AndreasReitberger.Shared.FontIcons;assembly=SharedMauiXamlStylesLibrary"
```xaml

If you already have used our style library, please replace all StaticResource as followd.

```xaml
<!-- Replace -->
{StaticResource MaterialDesign_{IconName}}
<!-- with -->
{x:Static icons:MaterialIcons.{IconName}}
```

# Available fonts

* MaterialDesign: {x:Static icons:MaterialIcons.{IconName}}
* FluentIcon: {x:Static icons:FluentIcons.{IconName}}
* Syncfusion: {x:Static icons:SyncfusionIcons.{IconName}}