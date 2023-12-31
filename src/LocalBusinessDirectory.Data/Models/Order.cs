﻿namespace LocalBusinessDirectory.Data.Models;
public class Order
{
    public Order()
    {
        
    }

    public Order(OrderWithUser order)
    {
        Id = order.Id;
        UserId = order.UserId;
        OfferId = order.OfferId;
        Offer = order.Offer;
        Status = order.Status;
        PriceWhenBought = order.PriceWhenBought;
        IsDiscounted = order.IsDiscounted;
    }

    public int Id { get; set; }
    public int UserId { get; set; }
    public string? OfferId { get; set; }
    /// <summary>
    /// Db does not return <see cref="Offer.Rating"/> or <see cref="Offer.NumberOfRatings"/>
    /// </summary>
    public Offer? Offer { get; set; }
    public string? BusinessName { get; set; }
    public OrderStatus Status { get; set; }
    public decimal PriceWhenBought { get; set; }
    public bool IsDiscounted { get; set; }
}
