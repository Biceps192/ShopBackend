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
        IEnumerable<Product> GetProductsByCategory(int id, int page, int pageSize);
        IEnumerable<ProductByBasketIdDto> GetProductsByBasketId(int basketId);
        IEnumerable<Product> GetProductsByIds(List<int> productIds);
        IEnumerable<Product> GetProductsBySubcategory(int subcategoryId);
        bool AddToFavourite(int userId, int productId);
        IEnumerable<FavouritesByUserIdReadDto> GetFavoriteProductsByUserId(int userId);
        int GetCountProductsByCategory(int id);
    }
}
