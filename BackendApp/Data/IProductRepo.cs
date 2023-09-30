using BackendApp.Models;

namespace BackendApp.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
    }
}
