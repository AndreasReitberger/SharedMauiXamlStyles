using AndreasReitberger.Shared.Core.Hosting;
using AndreasReitberger.Shared.Core.Interfaces;
using AndreasReitberger.Shared.Core.Utilities;
using AndreasReitberger.Shared.Hosting;
using AndreasReitberger.Shared.Syncfusion.Hosting;
using AndreasReitberger.Shared.Syncfusion.Toolkit.Hosting;
using CommunityToolkit.Maui;
using SharedMauiXamlStylesLibrary.SampleApp.Hosting;
using SharedMauiXamlStylesLibrary.SampleApp.Utilities;
using Syncfusion.Licensing;
using Syncfusion.Maui.Core.Hosting;
#if DEBUG
using Microsoft.Extensions.Logging;
#endif
using System.Diagnostics;

namespace SharedMauiXamlStylesLibrary.SampleApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            AppDomain.CurrentDomain.FirstChanceException += (s, e) =>
            {
#if RELEASE && Alpha && false
            EventManager.Instance?.LogError(new AppErrorEvent() 
            { 
                Exception = e.Exception, 
                Message = $"FirstChanceException: {e.Exception.Message}",
                SourceName = "AppDomain.CurrentDomain.FirstChanceException" 
            });
#endif
                if (e.Exception is FormatException sexc)
                {
                    Debug.WriteLine($"FormatException occurred: {sexc.Message}\n{sexc.StackTrace}");
#if Alpha && false
                // Crashes the app to send notifications here to early
                ToastManager.ShowToastNotificationAsync($"FirstChanceException: {sexc.Message}\n{sexc.StackTrace}");
#endif
                }
                Debug.WriteLine(e.Exception.ToString());
            };
            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureDispatching() //https://github.com/dotnet/maui/blob/main/src/Core/src/Hosting/Dispatching/AppHostBuilderExtensions.cs
                .ConfigureCoreLibrary()
                .ConfigureSyncfusionCore()
                .InitializeSharedMauiStyles()
                .InitializeSharedSyncfusionStyles()
                .InitializeSharedSyncfusionToolkitStyles()
                .ConfigureApp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
            builder.Services.AddLogging(configure => configure.AddDebug());
#endif

            if (builder.Services.BuildServiceProvider().GetService<IUserSecretsManager>() is UserSecretsManager usm)
            {
                if (usm.ReadSection<SecretAppSetting>("ExampleApp") is SecretAppSetting appSettings)
                {
                    //Register Syncfusion license
                    SyncfusionLicenseProvider.RegisterLicense(appSettings.SyncfusionApiKey);
                }
            }
            return builder.Build();
        }
    }
}