using BackendApp.Dto.ProductDto;
using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IProductRepo
    {
        bool SaveChanges();
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        IEnumerable<Product> GetProductsByCategory(int id);
        IEnumerable<ProductByBasketIdDto> GetProductsByBasketId(int basketId);
        IEnumerable<Product> GetProductsByIds(List<int> productIds);

    }
}
