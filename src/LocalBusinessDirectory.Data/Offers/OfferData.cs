using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Data.Sql;

namespace LocalBusinessDirectory.Data.Offers;
public class OfferData : IOfferData
{
    private readonly ISqlAccess _sql;

    public OfferData(ISqlAccess sql)
    {
        _sql = sql;
    }

    public async Task CreateOffer(Offer offer)
    {
        await _sql.ExecuteAsync("spOffers_Create", offer);
    }

    public async Task DeleteOffer(Offer offer)
    {
        await _sql.ExecuteAsync("spOffers_Delete", new { offer.Id });
    }

    public async Task<List<Offer>> GetByBusinessId(string id)
    {
        return await _sql.GetAsync<Offer>("spOffers_GetByBusinessId", new { BusinessId = id });
    }

    public async Task<Offer> GetById(string id)
    {
        return await _sql.GetFirstOrDefaultAsync<Offer>("spOffers_GetById", new { Id = id });
    }

    public async Task Update(Offer offer)
    {
        await _sql.ExecuteAsync("spOffers_Update", offer);
    }
}
