using AutoMapper;
using BackendApp.Data;
using BackendApp.Dto;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly IProductRepo _productRepo;
        private readonly IMapper _mapper;

        public ProductController(IProductRepo productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts()
        {
            var products = _productRepo.GetProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }

        [HttpGet("{id}")]
        public ActionResult<ProductReadDto> GetProduct(int id)
        {
            var product = _productRepo.GetProductById(id);
            if (product != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(product));

            }
            return NotFound();
        }
    }
}
