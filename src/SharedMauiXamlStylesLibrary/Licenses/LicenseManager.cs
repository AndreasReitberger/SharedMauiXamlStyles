using AndreasReitberger.Shared.Core.Documentation;

namespace AndreasReitberger.Shared.Licenses
{
    public partial class LicenseManager
    {
        readonly List<LibraryInfo> libraryInfos = new()
        {
            new LibraryInfo("Material Design Icons", "https://github.com/google/material-design-icons", "", "Apache License 2.0", "https://github.com/google/material-design-icons/blob/master/LICENSE", stateChanged: false),
            new LibraryInfo("Font Awesome", "https://github.com/FortAwesome/Font-Awesome", "", "Font Awesome Free License", "https://github.com/FortAwesome/Font-Awesome/blob/6.x/LICENSE.txt", stateChanged: false),
            new LibraryInfo("Montserrat (Google Font)", "https://fonts.google.com/specimen/Montserrat", "", "Open Font License", "https://scripts.sil.org/cms/scripts/page.php?site_id=nrsi&id=OFL", stateChanged: false),
        };

        public List<LibraryInfo> Libraries => libraryInfos;

    }
}
