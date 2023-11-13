using BackendApp.IRepo;
using BackendApp.Models;
using Microsoft.Identity.Client;

namespace BackendApp.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Subcategory> GetAllSubcategoriesByCategory(int id);
        void CreateSubcategory(Subcategory subcategory);
    }

    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepo _repo;

        public CategoryService(ICategoryRepo repo)
        {
            _repo = repo;
        }

        public void CreateSubcategory(Subcategory subcategory)
        {
            _repo.CreateSubcategory(subcategory);
            _repo.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _repo.GetCategories();
        }

        public IEnumerable<Subcategory> GetAllSubcategoriesByCategory(int id)
        {
            return _repo.GetSubcategoriesByCategory(id);
        }
    }
}
