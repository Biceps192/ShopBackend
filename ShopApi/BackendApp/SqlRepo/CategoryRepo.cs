using BackendApp.Data;
using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.SqlRepo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ShopContext _context;

        public CategoryRepo(ShopContext context)
        {
            _context = context;
        }

        public void CreateSubcategory(Subcategory subcategory)
        {
            _context.Subcategories.Add(subcategory);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Subcategory> GetSubcategoriesByCategory(int id)
        {
            return _context.Subcategories.Where(x => x.CategoryId == id).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
