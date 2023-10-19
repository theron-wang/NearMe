using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation.Attributes;
public class GreaterThanAttribute<T> : ValidationAttribute where T : IComparable
{
    private readonly T _greaterThan;

    public GreaterThanAttribute(T greaterThan)
    {
        _greaterThan = greaterThan;
    }

    public override bool IsValid(object? value)
    {
        return _greaterThan.CompareTo(value) < 0;
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name[0].ToString().ToUpper()}{name[1..]} must be greater than {_greaterThan}.";
    }
}
