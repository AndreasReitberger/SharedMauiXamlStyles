using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Syncfusion.Maui.SignaturePad;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfSignaturePadPageViewModel : BaseViewModel
    {
        #region Properties

        [ObservableProperty]
        public partial ObservableCollection<string> Sizes { get; set; } = [
            "S",
            "M",
            "L",
            "XL",
            "XXL"
            ];

        [ObservableProperty]
        public partial int SelectedSizeIndex { get; set; } = 0;

        partial void OnSelectedSizeIndexChanged(int value) => SelectedSize = Sizes[value];

        [ObservableProperty]
        public partial string SelectedSize { get; set; } = string.Empty;
        #endregion

        #region Constructor, LoadSettings

        public SfSignaturePadPageViewModel(IDispatcher dispatcher, IServiceProvider provider, IFileSaver fileSaver) : base(dispatcher, provider, fileSaver)
        {
            Dispatcher = dispatcher;
        }

        #endregion

        #region Commands

        [RelayCommand]
        async Task DrawCompleted(object? parameter)
        {

        }

        [RelayCommand]
        async Task DrawStarted(object? parameter)
        {

        }

        [RelayCommand]
        async Task Clear(object? parameter)
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
                    await captureResult?.CopyToAsync(memStream, ScreenshotFormat.Png, 100);
                    await FileSaver?.SaveAsync("signature.png", memStream);
                }
                ImageSource? imageSource = pad.ToImageSource();

                pad.Background = background;
                pad.StrokeColor = foreground;
            }
        }

        #endregion
    }
}
