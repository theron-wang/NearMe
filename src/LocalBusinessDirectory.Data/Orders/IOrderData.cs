using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Orders;
public interface IOrderData
{
    Task<List<Order>> GetOrdersByUser(string username);
    Task<bool> HasUserOrderedBefore(string username, string offerId);
    Task Order(Order order);
    Task Update(Order order);
}