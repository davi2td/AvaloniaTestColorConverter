using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;
using AvaloniaTestColorConverter.Models;

namespace AvaloniaTestColorConverter;

public class IsCheckedColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is Person person)
            return person.IsFictitious switch
            {
                true => new SolidColorBrush(Colors.Red),
                false => new SolidColorBrush(Colors.Green)
            };

        return new SolidColorBrush(Colors.Pink);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}