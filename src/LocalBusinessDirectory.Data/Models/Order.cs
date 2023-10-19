namespace LocalBusinessDirectory.Data.Models;
public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    /// <summary>
    /// Db does not return <see cref="Offer.Rating"/> or <see cref="Offer.NumberOfRatings"/>
    /// </summary>
    public Offer? Offer { get; set; }
    public decimal PriceWhenBought { get; set; }
    public bool IsDiscounted { get; set; }
}
