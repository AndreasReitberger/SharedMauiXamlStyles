using AndreasReitberger.Shared.Core.Theme;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AndreasReitberger.Shared.Syncfusion")]
namespace AndreasReitberger.Shared.Interfaces
{
    public interface IThemeManager
    {
        #region Properties
        public AppTheme Theme { get; }
        #endregion

        #region Methods
        //ResourceDictionary GetThemeResources(AppTheme theme);
        public void ApplyTheme(AppTheme theme, Application app);
        public void UpdatePrimaryThemeColor(ThemeColorInfo theme, Application app);
        #endregion
    }
}
