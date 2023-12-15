using BackendApp.Dto.ProductDto;
using BackendApp.IRepo;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Identity.Client;

namespace BackendApp.Services
{
    public interface IProductService
    {
        bool SaveChanges();
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
        void CreateProduct(Product product);
        IEnumerable<Product> GetProductsByCategory(int id, int page, int pageSize);
        IEnumerable<ProductByBasketIdDto> GetAllProductsByBasketId(int basketId);
        IEnumerable<Product> GetProductsByIds(List<int> id);
        IEnumerable<Product> GetProductsBySubcategory(int subcategoryId);
        bool AddToFavourite(int userId, int productId);
        IEnumerable<FavouritesByUserIdReadDto> GetFavouritesByUserId(int userId);
        int GetCountOfProducts(int id);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public void CreateProduct(Product product)
        {
            _productRepo.CreateProduct(product);
            _productRepo.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }

        public IEnumerable<Product> GetProductsByCategory(int id, int page, int pageSize)
        {
            return _productRepo.GetProductsByCategory(id, page, pageSize);
        }

        public int GetCountOfProducts(int id)
        {
            return _productRepo.GetCountProductsByCategory(id);
        }

        public bool SaveChanges()
        {
            return _productRepo != null;
        }

        public IEnumerable<ProductByBasketIdDto> GetAllProductsByBasketId(int basketId) 
        {
            return _productRepo.GetProductsByBasketId(basketId);
        }

        public IEnumerable<Product> GetProductsByIds(List<int> id)
        {
            return _productRepo.GetProductsByIds(id);
        }

        public IEnumerable<Product> GetProductsBySubcategory(int subcategoryId)
        {
            return _productRepo.GetProductsBySubcategory(subcategoryId);
        }

        public bool AddToFavourite(int userId, int productId)
        {
            return _productRepo.AddToFavourite(userId, productId);
        }

        public IEnumerable<FavouritesByUserIdReadDto> GetFavouritesByUserId(int userId)
        {
            return _productRepo.GetFavoriteProductsByUserId(userId);
        }
    }
}
