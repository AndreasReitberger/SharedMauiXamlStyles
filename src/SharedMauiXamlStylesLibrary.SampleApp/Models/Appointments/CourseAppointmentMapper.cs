using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.Models.Appointments
{
    public partial class CourseAppointmentMapper
    {
        #region  Properties
        public Guid CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsAllDay { get; set; }
        public string Notes { get; set; } = string.Empty;
        public TimeZoneInfo? StartTimeZone { get; set; }
        public TimeZoneInfo? EndTimeZone { get; set; }
        public Guid Id { get; set; }
        public Color? Foreground { get; set; }
        public Brush? Background { get; set; }
        public object? RecurrenceId { get; set; }
        public string RecurrenceRule { get; set; } = string.Empty;
        public ObservableCollection<DateTime> RecurrenceExceptions { get; set; } = [];

        public string Name => $"{CourseName} ({From.TimeOfDay} - {To.TimeOfDay})";

        #endregion
    }
}
