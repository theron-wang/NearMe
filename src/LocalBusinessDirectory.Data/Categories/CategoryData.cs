using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Data.Sql;

namespace LocalBusinessDirectory.Data.Categories;
public class CategoryData : ICategoryData
{
    private readonly ISqlAccess _sql;

    public CategoryData(ISqlAccess sql)
    {
        _sql = sql;
    }

    public async Task<List<Category>> GetCategories()
    {
        return await _sql.GetAsync<Category>("spCategories_GetAll", new { });
    }
}
