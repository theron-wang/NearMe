namespace LocalBusinessDirectory.Data.Models;

public class Address
{
    public int Number { get; set; }
    public string Street { get; set; } = string.Empty;
    public string? Suite { get; set; }
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;

    public string Format()
    {
        return $"{Number} {Street}{(string.IsNullOrWhiteSpace(Suite) ? "" : $", {Suite}")}, {City}, {State} {ZipCode}";
    }
}
