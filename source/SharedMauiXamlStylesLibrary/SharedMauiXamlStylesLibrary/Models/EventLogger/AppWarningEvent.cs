using AndreasReitberger.Shared.Enums;

namespace AndreasReitberger.Shared.Models.EventLogger
{
    public class AppWarningEvent : AppEvent
    {
        #region Properties

        #endregion

        #region Constructor
        public AppWarningEvent()
        {
            Level = ErrorLevel.Warning;
        }
        #endregion
    }
}
