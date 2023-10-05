namespace LocalBusinessDirectory.Data.Ratings;

public interface IRater
{
    Task<int?> GetCurrentRating(string username, string relatedToId);
    Task Rate(string username, string relatedToId, int rating);
}