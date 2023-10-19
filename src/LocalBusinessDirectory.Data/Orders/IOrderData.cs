using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Orders;
public interface IOrderData
{
    Task DeleteOrder(int id);
    Task<Order?> GetOrderById(int id);
    Task<List<Order>> GetOrdersByUser(int userId);
    Task Order(Order order);
    Task Update(Order order);
}