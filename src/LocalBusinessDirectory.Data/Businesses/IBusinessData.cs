using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Businesses;
public interface IBusinessData
{
    Task CreateBusiness(Business business);
    Task<Business?> GetBusinessById(string id);
    Task<List<Business>> GetBusinesses();
    Task UpdateBusiness(Business business);
}