using BethanysPieShop.Models;

namespace BethanysPieShop.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
