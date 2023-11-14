﻿using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.Services
{
    public interface IProductService
    {
        bool SaveChanges();
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
        void CreateProduct(Product product);
        IEnumerable<Product> GetProductsByCategory(int id);
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

        public IEnumerable<Product> GetProductsByCategory(int id)
        {
            return _productRepo.GetProductsByCategory(id);
        }

        public bool SaveChanges()
        {
            return _productRepo != null;
        }
    }
}