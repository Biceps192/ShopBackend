﻿using AutoMapper;
using BackendApp.Dto.ProductDto;
using BackendApp.IRepo;
using BackendApp.Models;
using BackendApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts()
        {
            var products = _productService.GetProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }

        [HttpGet("{id}")]
        public ActionResult<ProductReadDto> GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(product));

            }
            return NotFound();
        }

        [HttpPost]
        [ActionName(nameof(CreateProduct))]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto product)
        {
            var productModel = _mapper.Map<Product>(product);
            _productService.CreateProduct(productModel);

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtAction(nameof(GetProductById), new { Id = productReadDto.Id }, productReadDto);
        }

        [HttpGet]
        [Route("GetByCategory")]
        public ActionResult<IEnumerable<ProductReadDto>> GetProductsByCategoryId(int id)
        {
            var products = _productService.GetProductsByCategory(id);

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }

        [HttpGet]
        [Route("GetAllProductsByBasketId")]
        public ActionResult<IEnumerable<ProductByBasketIdDto>> GetAllProductsByBasketId(int basketId)
        {
            var products = _productService.GetAllProductsByBasketId(basketId);

            return Ok(products);
        }

        [HttpGet]
        [Route("GetProductsByIds")]
        public ActionResult<IEnumerable<Product>> GetProductsByIds(List<int> productIds)
        {
            if (productIds == null)
            {
                return BadRequest("Sorry, ur bad");
            }

            var products = _productService.GetProductsByIds(productIds);

            if (products == null)
            {
                return NotFound("Sorry, not found");
            }

            return Ok(products);
        }
    }
}
