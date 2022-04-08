using AndreasReitberger.Shared.Enums;

namespace AndreasReitberger.Shared.Models.EventLogger
{
    public class AppInfoEvent : AppEvent
    {
        #region Properties

        #endregion

        #region Constructor
        public AppInfoEvent()
        {
            Level = ErrorLevel.Info;
        }
        #endregion
    }
}
