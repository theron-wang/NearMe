using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation.Attributes;
public class FileSizeAttribute : ValidationAttribute
{
    private readonly int _sizeInMb;

    public FileSizeAttribute(int sizeInMb)
    {
        _sizeInMb = sizeInMb;
    }

    public override bool IsValid(object? value)
    {
        if (value is IBrowserFile file)
        {
            return file.Size <= _sizeInMb * 1024 * 1024;
        }
        throw new InvalidOperationException($"Value must be of type IBrowserFile.");
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name[0].ToString().ToUpper()}{name[1..]} must be smaller than {_sizeInMb}MB";
    }
}