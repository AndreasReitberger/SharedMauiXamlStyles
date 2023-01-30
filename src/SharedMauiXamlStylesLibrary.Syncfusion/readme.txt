﻿# Important
This is an addon of our `SharedMauXamlStyles` library (https://github.com/AndreasReitberger/SharedMauiXamlStyles).
In order to get this extension to work, make sure that also the core project above is installed on your app project.

# Getting started
Open the `MauiProgramm.cs` file and add `InitializeSharedMauiStyles()` and `InitializeSharedSyncfusionStyles()`

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
        .InitializeSharedMauiStyles()  // <== Add this line
        .InitializeSharedSyncfusionStyles()  // <== Add this line
        ;
}
```

To add the Styles and Colors to your app theme, you can merge the `ResourceDictionary` at your App.xaml page.

```xaml
    <ResourceDictionary.MergedDictionaries>
        <!-- your own stuff -->
        <ResourceDictionary Source="/Themes/DefaultColors.xaml" />

        <!-- Library -->
        <syncfusion:Fonts />
        <syncfusion:Styles />
        <syncfusion:Templates />
        <shared:DefaultTheme/>
    </ResourceDictionary.MergedDictionaries>
```

For further instructions or issues, please visit the project page on github.
https://github.com/AndreasReitberger/SharedMauiXamlStyles

# Important update notice
Since 1.0.9, we changed the location for the `FontIconKeys`.
In order to use the library, you need to migrate to use the new `FontIconKeys` instead.

Please follow the guide below.

# Migration Guide

https://github.com/AndreasReitberger/SharedMauiXamlStyles/wiki/Use-Icons-in-XAML-content#reference-icons

# Icons reference

In each XAML content, where you want to use the icons, please reference following namespace.

```xaml
xmlns:icons="clr-namespace:AndreasReitberger.Shared.Syncfusion.FontIcons;assembly=SharedMauiXamlStylesLibrary"
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