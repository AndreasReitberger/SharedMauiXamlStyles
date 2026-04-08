#if WINDOWS
using Microsoft.Maui.Handlers;
#endif
using AndreasReitberger.Shared.Core.Hosting;
using AndreasReitberger.Shared.Core.Localization;
using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;
using SharedMauiXamlStylesLibrary.SampleApp.Views;
using CommunityToolkit.Maui;

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
                .RegisterMainViews()
                .ConfigureLocalizationManager([
                    //https://www.fincher.org/Utilities/CountryLanguageList.shtml
                    new("English", "English", LocalizationManager.GetImageUri("", "en-us"), "Andreas", "en-US", 100, true),
                    new("German", "Deutsch", LocalizationManager.GetImageUri("", "de-de"), "Andreas", "de-DE", 100, true),
                    new("Spanish", "Español", LocalizationManager.GetImageUri("", "es-es"), "", "es-ES", 0, false),
                    new("Portuguese", "Português", LocalizationManager.GetImageUri("", "pt-pt"), "", "pt-PT", 0, false),
                    new("Brazilian", "Brasileira", LocalizationManager.GetImageUri("", "pt-br"), "", "pt-BR", 0, false),
                ], "")
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
        public static MauiAppBuilder RegisterMainViews(this MauiAppBuilder builder)
        {
            // Example: https://github.com/microsoft/dotnet-podcasts/blob/main/src/Mobile/Pages/PagesExtensions.cs
            builder.Services.AddSingleton<AppShell, AppShellViewModel>();
            // Main view models
            builder.Services.AddSingleton<SfAccordionsPage, SfAccordionsPageViewModel>();
            builder.Services.AddSingleton<ActivityIndicatorsPage, ActivityIndicatorsPageViewModel>();
            builder.Services.AddSingleton<BordersPage, BordersPageViewModel>();
            builder.Services.AddSingleton<ButtonsPage, ButtonsPageViewModel>();
            builder.Services.AddSingleton<BoxViewsPage, BoxViewsPageViewModel>();
            builder.Services.AddSingleton<CheckBoxesPage, CheckBoxesPageViewModel>();
            builder.Services.AddSingleton<CollectionViewPage, CollectionViewPageViewModel>();
            builder.Services.AddSingleton<EntryPage, EntryPageViewModel>();
            builder.Services.AddSingleton<FontSizePage, LablesPageViewModel>();
            builder.Services.AddSingleton<LabelsPage, LablesPageViewModel>();
            builder.Services.AddSingleton<MaterialDesignIconLabelsPage, IconLablesPageViewModel>();
            builder.Services.AddSingleton<TablerIconLabelsPage, IconLablesPageViewModel>();
            builder.Services.AddSingleton<LanguagesPage, LanguagesPageViewModel>();
            builder.Services.AddSingleton<GridsPage, GridsPageViewModel>();
            builder.Services.AddSingleton<EditorsPage, EditorsPageViewModel>();
            builder.Services.AddSingleton<PickersPage, PickersPageViewModel>();
            builder.Services.AddSingleton<ProgressBarsPage, ProgressBarsPageViewModel>();
            builder.Services.AddSingleton<SlidersPage, SlidersPageViewModel>();
            builder.Services.AddSingleton<SwitchesPage, SwitchesPageViewModel>();
            builder.Services.AddSingleton<SfCheckBoxesPage, SfCheckBoxesPageViewModel>();
            builder.Services.AddSingleton<SfComboBoxesPage, SfComboBoxesPageViewModel>();
            builder.Services.AddSingleton<SfExpandersPage, SfExpandersPageViewModel>();
            builder.Services.AddSingleton<SfNumericEntry, EntryPageViewModel>();
            builder.Services.AddSingleton<SfSchedulerCalendarPage, SfSchedulerCalendarPageViewModel>();
            builder.Services.AddSingleton<SfSegmentedControlPage, SfSegmentedControlPageViewModel>();
            builder.Services.AddSingleton<SfShimmerPage, SfShimmerPageViewModel>();
            builder.Services.AddSingleton<SfSignaturePadPage, SfSignaturePadPageViewModel>();
            builder.Services.AddSingleton<SfTreeMapPadPage, SfTreeMapPadPageViewModel>();
            builder.Services.AddSingleton<SfTabViewPage, SfTabViewPageViewModel>();
            builder.Services.AddSingleton<SfTemplatePage, TemplatePageViewModel>();
            builder.Services.AddSingleton<SfListViewPage, SfListViewPageViewModel>();
            builder.Services.AddSingleton<SfProgressBarPage, SfProgressBarPageViewModel>();
            builder.Services.AddSingleton<SfStepProgressBar, SfStepProgressBarViewModel>();
            builder.Services.AddSingleton<SfTextInputLayoutsPage, SfTextInputLayoutsPageViewModel>();
            builder.Services.AddSingleton<TemplatePage, TemplatePageViewModel>();

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
