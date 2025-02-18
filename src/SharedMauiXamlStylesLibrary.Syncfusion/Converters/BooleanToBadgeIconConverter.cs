using Syncfusion.Maui.Core;
using System.Globalization;

namespace AndreasReitberger.Shared.Syncfusion.Converters
{
    public class BooleanToBadgeIconConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is int online && online == 1 ? BadgeIcon.Available : BadgeIcon.Prohibit1;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
