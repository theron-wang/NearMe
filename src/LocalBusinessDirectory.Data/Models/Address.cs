namespace LocalBusinessDirectory.Data.Models;

public class Address
{
    public string AddressNumber { get; set; } = string.Empty;
    public string AddressStreet { get; set; } = string.Empty;
    public string? AddressSuite { get; set; }
    public string AddressCity { get; set; } = string.Empty;
    public string AddressState { get; set; } = string.Empty;
    public string AddressZipCode { get; set; } = string.Empty;

    public string Format()
    {
        return $"{AddressNumber} {AddressStreet}{(string.IsNullOrWhiteSpace(AddressSuite) ? "" : $", {AddressSuite}")}, {AddressCity}, {AddressState} {AddressZipCode}";
    }
}
