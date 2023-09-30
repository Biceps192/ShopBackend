using BackendApp.Data;
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
