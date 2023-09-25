namespace LocalBusinessDirectory.Data.Models;
#nullable disable
public class Business
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public Address Address { get; set; }
    public string CategoryName { get; set; }
    public double Rating { get; set; }
    public int NumberOfRatings { get; set; }
    public bool IsPartnered { get; set; }
}
