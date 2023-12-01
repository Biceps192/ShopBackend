using BackendApp.Data;
using BackendApp.Dto.ProductDto;
using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.SqlRepo
{
    public class ProductRepo: IProductRepo
    {
        private readonly ShopContext _context;

        public ProductRepo(ShopContext shopContext)
        {
            _context = shopContext;
        }

        public void CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Add(product);
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(int id)
        {
            var subcategories = _context.Subcategories.Where(x => x.CategoryId == id);

            var subcategoriesId = subcategories.Select(x => x.Id);

            return _context.Products.Where(x => subcategoriesId.Contains(x.SubcategoryId)).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<ProductByBasketIdDto> GetProductsByBasketId(int basketId)
        {
            var productBasket = _context.ProductBasket
                .Where(x => x.BasketId == basketId)
                .Select(x => new ProductByBasketIdDto
                {
                    ProductId = x.ProductId,
                    Price = x.Product.Price,
                    Name = x.Product.Name,
                    Quantity = x.Quantity
                })
                .ToList();

            return productBasket;
        }

        public IEnumerable<Product> GetProductsByIds(List<int> productIds)
        {
            return _context.Products.Where(x => productIds.Contains(x.Id)).ToList();
        }

        public IEnumerable<Product> GetProductsBySubcategory(int subcategoryId)
        {
            var products = _context.Products.Where(x => x.SubcategoryId == subcategoryId).ToList();

            return products;
        }
    }
}
