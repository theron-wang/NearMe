namespace LocalBusinessDirectory.Data.Models;

#nullable disable
public class Offer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string BusinessId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public OfferType Type { get; set; }
    public double Rating { get; set; }
    public int NumberOfRatings { get; set; }
    public decimal Price { get; set; }
}
