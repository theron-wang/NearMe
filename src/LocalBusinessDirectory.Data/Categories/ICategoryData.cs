using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Categories;
public interface ICategoryData
{
    Task<List<Category>> GetCategories();
}