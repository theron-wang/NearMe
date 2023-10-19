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
        await _sql.ExecuteAsync("spOrders_Order", new { order.UserId, OfferId = order.Offer?.Id, order.PriceWhenBought, order.IsDiscounted });
    }

    public async Task Update(Order order)
    {
        await _sql.ExecuteAsync("spOrders_Update", new OrderDb(order));
    }

    public async Task<Order?> GetOrderById(int id)
    {
        return await _sql.GetFirstOrDefaultAsync<Order>("spOrders_GetOrderById", new { Id = id });
    }

    public async Task<List<Order>> GetOrdersByUser(int userId)
    {
        return await _sql.GetAsync<Order>("spOrders_GetOrdersByUser", new { UserId = userId });
    }

    public async Task DeleteOrder(int id)
    {
        await _sql.ExecuteAsync("spOrders_Delete", new { Id = id });
    }
}
