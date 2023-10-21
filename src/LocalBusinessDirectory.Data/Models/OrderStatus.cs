namespace LocalBusinessDirectory.Data.Models;
public enum OrderStatus
{
    Created,
    InProgress = 1000,
    Fulfilled = 2000,
    Cancelled = 3000
}
