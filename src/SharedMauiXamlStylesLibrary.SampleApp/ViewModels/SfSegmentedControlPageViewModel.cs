using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfSegmentedControlPageViewModel : BaseViewModel
    {

        #region Properties

        [ObservableProperty]
        ObservableCollection<string> sizes = [
            "S",
            "M",
            "L",
            "XL",
            "XXL"
            ];

        [ObservableProperty]
        int selectedSizeIndex = 0;
        partial void OnSelectedSizeIndexChanged(int value) => SelectedSize = Sizes[value];

        [ObservableProperty]
        string selectedSize = string.Empty;
        #endregion

        #region Constructor, LoadSettings

        public SfSegmentedControlPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
        }

        #endregion

    }
}
