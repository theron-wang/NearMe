using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Data.Sql;

namespace LocalBusinessDirectory.Data.Orders;
public class OrderData : IOrderData
{
    private readonly ISqlAccess _sql;

    public OrderData(ISqlAccess sql)
    {
        _sql = sql;
    }

    public async Task Order(Order order)
    {
        await _sql.ExecuteAsync("spOrders_Create", new { order.UserId, OfferId = order.Offer?.Id, order.PriceWhenBought, order.IsDiscounted });
    }

    public async Task Update(Order order)
    {
        await _sql.ExecuteAsync("spOrders_Update", new OrderDb(order));
    }

    public async Task<List<Order>> GetOrdersByUser(string username)
    {
        return await _sql.GetAsync<Order, Order, Offer>("spOrders_GetByUser", new { Username = username }, (or, of) =>
        {
            or.Offer = of;
            return or;
        });
    }

    public async Task<bool> HasUserOrderedBefore(string username, string offerId)
    {
        return await _sql.GetFirstOrDefaultAsync<bool>("spOrders_HasUserOrderedBefore", new { Username = username, OfferId = offerId });
    }
}
