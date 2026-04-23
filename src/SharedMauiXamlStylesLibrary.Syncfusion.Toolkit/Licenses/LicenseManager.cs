using AndreasReitberger.Shared.Core.Documentation;

namespace AndreasReitberger.Shared.Syncfusion.Licenses
{
    public partial class LicenseManager
    {
        readonly List<LibraryInfo> libraryInfos =
        [
            new LibraryInfo(
                "Syncfusion® Toolkit for .NET MAUI", 
                "https://github.com/syncfusion/maui-toolkit/", 
                "The Syncfusion® Toolkit for .NET MAUI is a high-performance collection of UI controls designed to streamline cross-platform app development across Android, iOS, macOS, and Windows", 
                "MIT",
                "https://github.com/syncfusion/maui-toolkit?tab=MIT-1-ov-file", 
                stateChanged: false
                ),
        ];

        public List<LibraryInfo> Libraries => libraryInfos;

    }
}
