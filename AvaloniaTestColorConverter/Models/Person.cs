using AvaloniaTestColorConverter.ViewModels;
using ReactiveUI;

namespace AvaloniaTestColorConverter.Models;

public class Person : ViewModelBase
{
    private string _firstName;
    private bool _isFictitious;
    private string _lastName;

    public Person(string firstName, string lastName, bool isFictitious)
    {
        _firstName = firstName;
        _lastName = lastName;

        _isFictitious = isFictitious;
    }

    public string FirstName
    {
        get => _firstName;
        set => this.RaiseAndSetIfChanged(ref _firstName, value);
    }

    public string LastName
    {
        get => _lastName;
        set => this.RaiseAndSetIfChanged(ref _lastName, value);
    }

    public bool IsFictitious
    {
        get => _isFictitious;
        set => this.RaiseAndSetIfChanged(ref _isFictitious, value);
    }
}