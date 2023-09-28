using BackendApp.Models;

namespace BackendApp.Data
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }
}
