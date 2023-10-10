using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Data.Sql;

namespace LocalBusinessDirectory.Data.Businesses;
public class BusinessData : IBusinessData
{
    private readonly ISqlAccess _sql;

    public BusinessData(ISqlAccess sql)
    {
        _sql = sql;
    }

    public async Task CreateBusiness(Business business)
    {
        await _sql.ExecuteAsync("spBusinesses_Create", new BusinessDbInput(business));
    }

    public async Task<List<Business>> GetBusinesses()
    {
        return await _sql.GetAsync<Business, Business, Address>("spBusinesses_GetAll", new { }, (b, a) =>
        {
            b.Address = a;
            return b;
        }, "AddressNumber");
    }

    public async Task<Business?> GetBusinessById(string id)
    {
        return (await _sql.GetAsync<Business, Business, Address>("spBusinesses_GetById", new { Id = id }, (b, a) =>
        {
            b.Address = a;
            return b;
        }, "AddressNumber")).FirstOrDefault();
    }

    public async Task UpdateBusiness(Business business)
    {
        await _sql.ExecuteAsync("spBusinesses_Update", new BusinessDbInput(business));
    }
}
