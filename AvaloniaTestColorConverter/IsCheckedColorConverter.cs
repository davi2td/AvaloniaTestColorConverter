using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace AvaloniaTestColorConverter;

public class IsCheckedColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool)
            return value switch
            {
                false => new SolidColorBrush(Colors.Red),
                true => new SolidColorBrush(Colors.Green),
                _ => new SolidColorBrush(Colors.Purple)
            };

        return new SolidColorBrush(Colors.Pink);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}