using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace AvaloniaTestColorConverter;

public class MultiCellColorConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        return values[1] switch
        {
            true when (string?)values[0] == "Neil" => new SolidColorBrush(Colors.Green),
            true when (string?)values[0] == "Buzz" => new SolidColorBrush(Colors.Yellow),
            _ => new SolidColorBrush(Colors.Purple)
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}