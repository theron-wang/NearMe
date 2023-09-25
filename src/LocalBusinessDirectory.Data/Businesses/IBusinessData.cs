using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Businesses;
public interface IBusinessData
{
    Task<List<Business>> GetBusinesses();
}