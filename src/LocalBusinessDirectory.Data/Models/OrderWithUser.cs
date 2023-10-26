namespace LocalBusinessDirectory.Data.Models;
public class OrderWithUser
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? OfferId { get; set; }
    /// <summary>
    /// Db does not return <see cref="Offer.Rating"/> or <see cref="Offer.NumberOfRatings"/>
    /// </summary>
    public Offer? Offer { get; set; }
    public User? User { get; set; }
    public OrderStatus Status { get; set; }
    public decimal PriceWhenBought { get; set; }
    public bool IsDiscounted { get; set; }
}
