namespace LocalBusinessDirectory.Data.Models;
internal class OrderDb
{
    public OrderDb(Order order)
    {
        Id = order.Id;
        UserId = order.UserId;
        OfferId = order.Offer?.Id;
        PriceWhenBought = order.PriceWhenBought;
        IsDiscounted = order.IsDiscounted;
        Status = order.Status;
    }

    public int Id { get; set; }
    public int UserId { get; set; }
    /// <summary>
    /// Db does not return <see cref="Offer.Rating"/> or <see cref="Offer.NumberOfRatings"/>
    /// </summary>
    public string? OfferId { get; set; }
    public OrderStatus Status { get; set; }
    public decimal PriceWhenBought { get; set; }
    public bool IsDiscounted { get; set; }
}
