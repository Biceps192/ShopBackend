using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Subcategory> GetSubcategoriesByCategory(int id);
        void CreateSubcategory(Subcategory subcategory);
        bool SaveChanges();
    }
}
