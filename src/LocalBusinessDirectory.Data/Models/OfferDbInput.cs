namespace LocalBusinessDirectory.Data.Models;
internal class OfferDbInput
{
    public string Id { get; set; }
    public string BusinessId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public OfferType Type { get; set; }
    public decimal Price { get; set; }
    public OfferDbInput(Offer offer)
    {
        Id = offer.Id;
        BusinessId = offer.BusinessId;
        Name = offer.Name;
        Description = offer.Description;
        ImageUrl = offer.ImageUrl;
        Type = offer.Type;
        Price = offer.Price;
    }
}
