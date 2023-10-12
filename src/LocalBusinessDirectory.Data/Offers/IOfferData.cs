using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Offers;
public interface IOfferData
{
    Task CreateOffer(Offer offer);
    Task DeleteOffer(Offer offer);
    Task<List<Offer>> GetByBusinessId(string id);
    Task<Offer?> GetById(string id);
    Task Update(Offer offer);
}