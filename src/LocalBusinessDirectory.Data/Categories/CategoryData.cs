using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Categories;
public class CategoryData : ICategoryData
{
    public async Task<List<Category>> GetCategories()
    {
        await Task.Delay(Random.Shared.Next(100, 1000));

        return new()
        {
            new()
            {
                Name = "Restaurant"
            },
            new()
            {
                Name = "Store"
            },
            new()
            {
                Name = "Shipping"
            }
        };
    }
}
