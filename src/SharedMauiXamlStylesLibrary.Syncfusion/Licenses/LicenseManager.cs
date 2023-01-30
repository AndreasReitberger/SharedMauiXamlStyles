using AndreasReitberger.Shared.Core.Documentation;

namespace AndreasReitberger.Shared.Syncfusion.Licenses
{
    public partial class LicenseManager
    {
        readonly List<LibraryInfo> libraryInfos = new()
        {
            new LibraryInfo("UIFontIcons (by Syncfusion)", "https://www.syncfusion.com/", "", "ESSENTIAL STUDIO SOFTWARE LICENSE AGREEMENT", "https://www.syncfusion.com/license/studio/17.4.0.39/syncfusion_essential_studio_eula.pdf", stateChanged: false),
        };

        public List<LibraryInfo> Libraries => libraryInfos;

    }
}
