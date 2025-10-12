#if WINDOWS
using Microsoft.Maui.Handlers;
#endif
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
            builder.Services.AddSingleton<ActivityIndicatorsPageViewModel>();
            builder.Services.AddSingleton<BordersPageViewModel>();
            builder.Services.AddSingleton<ButtonsPageViewModel>();
            builder.Services.AddSingleton<CheckBoxesPageViewModel>();
            builder.Services.AddSingleton<CollectionViewPageViewModel>();
            builder.Services.AddSingleton<LablesPageViewModel>();
            builder.Services.AddSingleton<LanguagesPageViewModel>();
            builder.Services.AddSingleton<ComboBoxesPageViewModel>();
            builder.Services.AddSingleton<EntryPageViewModel>();
            builder.Services.AddSingleton<BoxViewsPageViewModel>();
            builder.Services.AddSingleton<GridsPageViewModel>();
            builder.Services.AddSingleton<EditorsPageViewModel>();
            builder.Services.AddSingleton<PickersPageViewModel>();
            builder.Services.AddSingleton<ProgressBarsPageViewModel>();
            builder.Services.AddSingleton<SlidersPageViewModel>();
            builder.Services.AddSingleton<SwitchesPageViewModel>();
            builder.Services.AddSingleton<SfCheckBoxesPageViewModel>();
            builder.Services.AddSingleton<SfExpandersPageViewModel>();
            builder.Services.AddSingleton<SfSchedulerCalendarPageViewModel>();
            builder.Services.AddSingleton<SfSegmentedControlPageViewModel>();
            builder.Services.AddSingleton<SfShimmerPageViewModel>();
            builder.Services.AddSingleton<SfSignaturePadPageViewModel>();
            builder.Services.AddSingleton<SfTreeMapPadPageViewModel>();
            builder.Services.AddSingleton<TabViewPageViewModel>();
            builder.Services.AddSingleton<TemplatePageViewModel>();
            builder.Services.AddSingleton<SfListViewPageViewModel>();
            builder.Services.AddSingleton<SfProgressBarPageViewModel>();
            builder.Services.AddSingleton<SfStepProgressBarViewModel>();
            builder.Services.AddSingleton<TextInputLayoutsPageViewModel>();
            return builder;
        }
        public static MauiAppBuilder RegisterMainViews(this MauiAppBuilder builder)
        {
            // Example: https://github.com/microsoft/dotnet-podcasts/blob/main/src/Mobile/Pages/PagesExtensions.cs
            builder.Services.AddSingleton<AppShell>();
            // Main view models
            builder.Services.AddSingleton<AccordionsPage>();
            builder.Services.AddSingleton<ActivityIndicatorsPage>();
            builder.Services.AddSingleton<BordersPage>();
            builder.Services.AddSingleton<ButtonsPage>();
            builder.Services.AddSingleton<BoxViewsPage>();
            builder.Services.AddSingleton<CheckBoxesPage>();
            builder.Services.AddSingleton<CollectionViewPage>();
            builder.Services.AddSingleton<ComboBoxesPage>();
            builder.Services.AddSingleton<EntryPage>();
            builder.Services.AddSingleton<FontSizePage>();
            builder.Services.AddSingleton<LabelsPage>();
            builder.Services.AddSingleton<LanguagesPage>();
            builder.Services.AddSingleton<GridsPage>();
            builder.Services.AddSingleton<EditorsPage>();
            builder.Services.AddSingleton<PickersPage>();
            builder.Services.AddSingleton<ProgressBarsPage>();
            builder.Services.AddSingleton<SlidersPage>();
            builder.Services.AddSingleton<SwitchesPage>();
            builder.Services.AddSingleton<SfCheckBoxesPage>();
            builder.Services.AddSingleton<SfExpandersPage>();
            builder.Services.AddSingleton<SfSchedulerCalendarPage>();
            builder.Services.AddSingleton<SfSegmentedControlPage>();
            builder.Services.AddSingleton<SfShimmerPage>();
            builder.Services.AddSingleton<SfSignaturePadPage>();
            builder.Services.AddSingleton<SfTreeMapPadPage>();
            builder.Services.AddSingleton<TabViewPage>();
            builder.Services.AddSingleton<TemplatePage>();
            builder.Services.AddSingleton<SfListViewPage>();
            builder.Services.AddSingleton<SfProgressBarPage>();
            builder.Services.AddSingleton<SfStepProgressBar>();
            builder.Services.AddSingleton<TextInputLayoutsPage>();
            return builder;
        }

        public static MauiAppBuilder RegisterDispatcher(this MauiAppBuilder builder)
        {
            // Example: https://github.com/jamesmontemagno/ToolkitMessenger/blob/master/MauiApp2/MauiProgram.cs
            IDispatcher? dispatcher = Dispatcher.GetForCurrentThread();
            if (dispatcher is not null)
                builder.Services.AddSingleton(dispatcher);
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
