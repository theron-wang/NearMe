using LocalBusinessDirectory.Data.Sql;

namespace LocalBusinessDirectory.Data.Ratings;
public class Rater : IRater
{
    private readonly ISqlAccess _sql;

    public Rater(ISqlAccess sql)
    {
        _sql = sql;
    }

    public async Task<int?> GetCurrentRating(string username, string relatedToId)
    {
        return await _sql.GetFirstOrDefaultAsync<int?>("spRatings_GetRating", new { Username = username, RelatedTo = relatedToId });
    }

    public async Task Rate(string username, string relatedToId, int rating)
    {
        await _sql.ExecuteAsync("spRatings_Rate", new { Username = username, RelatedTo = relatedToId, Rating = rating });
    }
}
