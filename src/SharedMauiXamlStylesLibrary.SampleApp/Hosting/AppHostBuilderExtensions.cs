using Microsoft.Maui.Handlers;
using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;
using SharedMauiXamlStylesLibrary.SampleApp.Views;

namespace SharedMauiXamlStylesLibrary.SampleApp.Hosting
{
    public static class AppHostBuilderExtensions
    {
        /*
         * The view models do not inherit from an interface, so they only need their concrete type provided to the AddSingleton<T> and AddTransient<T> methods.
         */

        public static MauiAppBuilder ConfigureApp(this MauiAppBuilder builder)
        {
            builder
                .RegisterDispatcher()
                .RegisterMainViewModels()
                .RegisterMainViews()
                ;

            ConfigureMappers();
            return builder;
        }

        /// <summary>
        /// Registers the main view models as Singleton.
        /// https://learn.microsoft.com/en-us/dotnet/architecture/maui/dependency-injection
        /// </summary>
        /// <param name="builder"></param>
        /// <returns>MauiAppBuilder</returns>
        public static MauiAppBuilder RegisterMainViewModels(this MauiAppBuilder builder)
        {
            // Main view models
            builder.Services.AddSingleton<AppShellViewModel>();
            builder.Services.AddSingleton<AccordionsPageViewModel>();
            builder.Services.AddSingleton<BordersPageViewModel>();
            builder.Services.AddSingleton<ButtonsPageViewModel>();
            builder.Services.AddSingleton<CheckBoxesPageViewModel>();
            builder.Services.AddSingleton<CollectionViewPageViewModel>();
            builder.Services.AddSingleton<LablesPageViewModel>();
            builder.Services.AddSingleton<ComboBoxesPageViewModel>();
            builder.Services.AddSingleton<EntryPageViewModel>();
            builder.Services.AddSingleton<BoxViewsPageViewModel>();
            builder.Services.AddSingleton<GridsPageViewModel>();
            builder.Services.AddSingleton<EditorsPageViewModel>();
            builder.Services.AddSingleton<PickersPageViewModel>();
            builder.Services.AddSingleton<ProgressBarsPageViewModel>();
            builder.Services.AddSingleton<FramesPageViewModel>();
            builder.Services.AddSingleton<SlidersPageViewModel>();
            builder.Services.AddSingleton<SwitchesPageViewModel>();
            builder.Services.AddSingleton<SfCheckBoxesPageViewModel>();
            builder.Services.AddSingleton<SfSegmentedControlPageViewModel>();
            builder.Services.AddSingleton<TabViewPageViewModel>();
            builder.Services.AddSingleton<SfListViewPageViewModel>();
            builder.Services.AddSingleton<TextInputLayoutsPageViewModel>();
            return builder;
        }
        public static MauiAppBuilder RegisterMainViews(this MauiAppBuilder builder)
        {
            // Example: https://github.com/microsoft/dotnet-podcasts/blob/main/src/Mobile/Pages/PagesExtensions.cs
            builder.Services.AddSingleton<AppShell>();
            // Main view models
            builder.Services.AddSingleton<AccordionsPage>();
            builder.Services.AddSingleton<BordersPage>();
            builder.Services.AddSingleton<ButtonsPage>();
            builder.Services.AddSingleton<BoxViewsPage>();
            builder.Services.AddSingleton<CheckBoxesPage>();
            builder.Services.AddSingleton<CollectionViewPage>();
            builder.Services.AddSingleton<ComboBoxesPage>();
            builder.Services.AddSingleton<EntryPage>();
            builder.Services.AddSingleton<LabelsPage>();
            builder.Services.AddSingleton<GridsPage>();
            builder.Services.AddSingleton<EditorsPage>();
            builder.Services.AddSingleton<PickersPage>();
            builder.Services.AddSingleton<ProgressBarsPage>();
            builder.Services.AddSingleton<FramesPage>();
            builder.Services.AddSingleton<SlidersPage>();
            builder.Services.AddSingleton<SwitchesPage>();
            builder.Services.AddSingleton<SfCheckBoxesPage>();
            builder.Services.AddSingleton<SfSegmentedControlPage>();
            builder.Services.AddSingleton<TabViewPage>();
            builder.Services.AddSingleton<SfListViewPage>();
            builder.Services.AddSingleton<TextInputLayoutsPage>();
            return builder;
        }

        public static MauiAppBuilder RegisterDispatcher(this MauiAppBuilder builder)
        {
            // Example: https://github.com/jamesmontemagno/ToolkitMessenger/blob/master/MauiApp2/MauiProgram.cs
            builder.Services.AddSingleton(Dispatcher.GetForCurrentThread());
            return builder;
        }
        public static void ConfigureMappers()
        {
#if WINDOWS
            ///Ref: https://github.com/dotnet/maui/issues/16047
            SwitchHandler.Mapper.AppendToMapping("CustomLabelSwitch", (handler, control) =>
            {
                handler.PlatformView.OnContent = null; // new Label { Text = "Foo", TextColor = Colors.Red }.ToPlatform(handler.MauiContext);
                handler.PlatformView.OffContent = null;
            });
#endif
        }
    }
}
