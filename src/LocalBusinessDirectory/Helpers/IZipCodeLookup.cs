namespace LocalBusinessDirectory.Helpers;

public interface IZipCodeLookup
{
    Task<ILookup<char, ZipCodeLookup.ZipCode>> Load();
}