using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfSegmentedControlPageViewModel : BaseViewModel
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

        public SfSegmentedControlPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
        }

        #endregion

    }
}
