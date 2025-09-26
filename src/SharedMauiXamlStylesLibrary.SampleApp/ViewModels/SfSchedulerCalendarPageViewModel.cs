using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SharedMauiXamlStylesLibrary.SampleApp.Models.Appointments;
using System.Collections.ObjectModel;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class SfSchedulerCalendarPageViewModel : BaseViewModel
    {
        #region Appointments

        [ObservableProperty]
        public partial ObservableCollection<CourseAppointmentMapper> Appointments { get; set; } = [];

        #endregion

        #region Constructor, LoadSettings

        public SfSchedulerCalendarPageViewModel(IDispatcher dispatcher, IServiceProvider provider) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            Appointments.Add(new()
            {
                StartTimeZone = TimeZoneInfo.Local,
                EndTimeZone = TimeZoneInfo.Local,
                CourseId = Guid.NewGuid(),
                CourseName = "Yoga - Beginners",
                Notes = "This are some notes",
                From = DateTime.Now,
                To = DateTime.Now.AddHours(1),
            });
        }

        #endregion

        #region Commands

        [RelayCommand]
        static Task ActionFromTap(object? parameter) => Shell.Current.DisplayAlert("Tapped", "You tapped an item", "OK");

        [RelayCommand]
        static Task ActionFromDoubleTap(object? parameter) => Shell.Current.DisplayAlert("Double tapped", "You double tapped an item", "OK");

        #endregion
    }
}
