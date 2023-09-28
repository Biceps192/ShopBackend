using BackendApp.Data;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ShopController: ControllerBase
    {
        private readonly IProductRepo _productRepo;

        public ShopController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _productRepo.GetProducts();

            return products.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productRepo.GetProductById(id);

            return product;
        }
    }
}
