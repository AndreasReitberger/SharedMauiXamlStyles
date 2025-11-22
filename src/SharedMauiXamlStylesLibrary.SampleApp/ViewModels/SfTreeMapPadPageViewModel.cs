using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SharedMauiXamlStylesLibrary.SampleApp.Models.Demo;
using Syncfusion.Maui.SignaturePad;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfTreeMapPadPageViewModel : BaseViewModel
    {
        #region Properties

        [ObservableProperty]
        public partial ObservableCollection<SoftwareInfo> Tools { get; set; } = [
            new() { Name = "Microsoft 365", Users = 2613, Group = "Office"},
            new() { Name = "Microsoft Teams", Users = 3156, Group = "Office"},
            new() { Name = "SAP", Users = 841, Group = "Office"},
            new() { Name = "Visual Studio", Users = 566, Group = "IDE"},
            new() { Name = "Visual Studio Code", Users = 862, Group = "IDE"},
            new() { Name = "Eclipse", Users = 1586, Group = "IDE"},
            ];

        [ObservableProperty]
        public partial ObservableCollection<SoftwareInfo> SelectedSoftwares { get; set; } = [];
        partial void OnSelectedSoftwaresChanged(ObservableCollection<SoftwareInfo> value)
        {

        }
        #endregion

        #region Constructor, LoadSettings

        public SfTreeMapPadPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
        }

        #endregion

        #region Commands

        [RelayCommand]
        static Task DrawCompleted(object? parameter)
            => Shell.Current.DisplayAlertAsync("Draw completed", "Draw completed event triggered.", "OK");

        [RelayCommand]
        static Task DrawStarted(object? parameter)
            => Shell.Current.DisplayAlertAsync("Draw started", "Draw started event triggered.", "OK");

        [RelayCommand]
        static void Clear(object? parameter)
        {
            if (parameter is SfSignaturePad pad)
            {
                pad.Clear();
            }
        }

        [RelayCommand]
        async Task Save(object? parameter)
        {
            if (parameter is SfSignaturePad pad)
            {
                var background = pad.Background;
                var foreground = pad.StrokeColor;

                pad.Background = Brush.White;
                pad.StrokeColor = Colors.Black;

                IScreenshotResult? captureResult = await pad.CaptureAsync();
                if (captureResult is not null)
                {
                    using MemoryStream memStream = new();
                    await captureResult.CopyToAsync(memStream, ScreenshotFormat.Png, 100);
                    if (FileSaver.Default is not null)
                        _ = await FileSaver.Default.SaveAsync("signature.png", memStream);
                }
                ImageSource? imageSource = pad.ToImageSource();

                pad.Background = background;
                pad.StrokeColor = foreground;
            }
        }

        #endregion
    }
}
