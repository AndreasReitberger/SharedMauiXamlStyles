using CommunityToolkit.Mvvm.ComponentModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.Models.Demo
{
    public partial class SoftwareInfo : ObservableObject
    {
        #region Properties

        [ObservableProperty]
        public partial int Users { get; set; }

        [ObservableProperty]
        public partial string Name { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Group { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string PersonInCharge { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Website { get; set; } = string.Empty;
        #endregion
    }
}
