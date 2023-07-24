using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;
using AvaloniaTestColorConverter.Models;

namespace AvaloniaTestColorConverter;

public class CellColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        //if (value is Models.Person { Status: "Scanned" })
        if (value is not Person person) return new SolidColorBrush(Colors.Blue);
        return person.FirstName switch
        {
            "Neil" => new SolidColorBrush(Colors.Green),
            "Buzz" => new SolidColorBrush(Colors.Yellow),
            _ => new SolidColorBrush(Colors.Purple)
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}