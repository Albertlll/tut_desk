using System;

using Avalonia.Data.Converters;
using System.Globalization;

namespace tutdesk.Converters
{
    public class PercentageToWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int progress)
            {
                return 3.0 * progress; // Увеличьте множитель по необходимости для подходящей ширины
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
