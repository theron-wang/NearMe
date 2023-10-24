namespace LocalBusinessDirectory.Data.Models;
public enum OrderStatus
{
    Placed,
    InProgress = 1000,
    Fulfilled = 2000,
    Cancelled = 3000
}
