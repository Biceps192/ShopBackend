﻿using BackendApp.Data;
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
    }
}