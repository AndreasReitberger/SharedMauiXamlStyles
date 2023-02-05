﻿using AndreasReitberger.Shared.Core.Theme;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AndreasReitberger.Shared.Syncfusion")]
namespace AndreasReitberger.Shared.Interfaces
{
    public interface IThemeManager
    {
        #region Properties
        AppTheme Theme { get; }
        #endregion

        #region Methods
        //ResourceDictionary GetThemeResources(AppTheme theme);
        void ApplyTheme(AppTheme theme, Application app);
        void UpdatePrimaryThemeColor(ThemeColorInfo theme, Application app);
        #endregion
    }
}
