using AndreasReitberger.Shared.Models.EventLogger;
using System.Collections.ObjectModel;

namespace AndreasReitberger.Shared.Interfaces
{
    public interface IEventManager
    {
        #region Properties
        bool AllowCrashAnalyticsData { get; set; }
        bool AllowAnalyticsData { get; set; }
        bool HasCriticalError { get; set; }

        public static ObservableCollection<AppEvent> Events { get; }
        #endregion

        #region Methods
        void LogError(Exception exception, bool forceReport = false);
        void LogError(AppErrorEvent error, bool forceReport = false);
        void LogInfo(AppInfoEvent info, bool forceReport = false);
        void LogWarning(AppWarningEvent warning, bool forceReport = false);
        void LogEvent(AppEvent appEvent, bool forceReport = false);
        void Clear();
        #endregion
    }
}
