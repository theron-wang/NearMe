using Microsoft.AspNetCore.Components.Forms;
using MimeTypes;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation.Attributes;
public class FileSizeAttribute : ValidationAttribute
{
    private readonly int _sizeInKb;

    public FileSizeAttribute(int sizeInKb)
    {
        _sizeInKb = sizeInKb * 1024;
    }

    public override bool IsValid(object? value)
    {
        if (value is IBrowserFile file)
        {
            return file.Size <= _sizeInKb * 1024;
        }
        throw new InvalidOperationException($"Value must be of type IBrowserFile.");
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name[0].ToString().ToUpper()}{name[1..]} must be smaller than {_sizeInKb}KB";
    }
}