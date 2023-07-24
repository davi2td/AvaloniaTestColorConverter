using System.Collections.Specialized;
using Avalonia.Collections;
using AvaloniaTestColorConverter.Models;
using ReactiveUI;

namespace AvaloniaTestColorConverter.ViewModels;

public class MainViewModel : ViewModelBase
{
    private AvaloniaList<Person>? _people;

    public MainViewModel()
    {
        _people = new AvaloniaList<Person>
        {
            new("Neil", "Armstrong", false),
            new("Buzz", "Lightyear", true),
            new("James", "Kirk", true)
        };
        People = new AvaloniaList<Person>(_people);
        People.CollectionChanged += test;
    }

    public AvaloniaList<Person>? People
    {
        get => _people;
        set
        {
            _people = value;
            this.RaiseAndSetIfChanged(ref _people, value);
        }
    }

    public string Greeting => "Yellow";

    public void ButtonChangeProp()
    {
        if (_people != null) _people[2].FirstName = "Neil";
    }

    public void ButtonAddRow()
    {
        _people?.Add(new Person("Neil", "Armstrong2", false));
    }

    private void test(object? sender, NotifyCollectionChangedEventArgs e)
    {
        // throw new NotImplementedException();
    }
}