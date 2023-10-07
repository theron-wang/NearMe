using Microsoft.AspNetCore.Components.Forms;
using MimeTypes;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation.Attributes;
public class FileTypeAttribute : ValidationAttribute
{
    private readonly string[] _fileTypes;

    public FileTypeAttribute(params string[] fileTypes)
    {
        _fileTypes = fileTypes;
    }

    public override bool IsValid(object? value)
    {
        if (value is IBrowserFile file)
        {
            return _fileTypes.Any(f => f.Equals(Path.GetExtension(file.Name), StringComparison.InvariantCultureIgnoreCase)) &&
                MimeTypeMap.GetExtension(file.ContentType) == Path.GetExtension(file.Name);
        }
        throw new InvalidOperationException($"Value must be of type IBrowserFile.");
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name[0].ToString().ToUpper()}{name[1..]} file format must be {string.Join(", ", _fileTypes)}";
    }
}