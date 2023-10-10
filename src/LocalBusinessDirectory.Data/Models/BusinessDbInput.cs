namespace LocalBusinessDirectory.Data.Models;
internal class BusinessDbInput
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string CategoryName { get; set; }
    public string AddressNumber { get; set; }
    public string AddressStreet { get; set; }
    public string? AddressSuite { get; set; }
    public string AddressCity { get; set; }
    public string AddressState { get; set; }
    public string AddressZipCode { get; set; }

    public BusinessDbInput(Business business)
    {
        Id = business.Id;
        Name = business.Name;
        Description = business.Description;
        ImageUrl = business.ImageUrl;
        CategoryName = business.CategoryName;
        AddressNumber = business.Address.AddressNumber;
        AddressStreet = business.Address.AddressStreet;
        AddressSuite = business.Address.AddressSuite;
        AddressCity = business.Address.AddressCity;
        AddressState = business.Address.AddressState;
        AddressZipCode = business.Address.AddressZipCode;
    }

}
