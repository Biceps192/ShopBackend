using AutoMapper;
using BackendApp.Models;
using BackendApp.Dto.BasketDto;
using BackendApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController: ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet("GetBasketByPublicUserId")]
        public ActionResult<BasketReadDto> GetBasketByPublicUserId(int id)
        {
            var basket = _basketService.GetBasketByPublicUserId(id);
            if (basket != null)
            {
                return Ok(_mapper.Map<BasketReadDto>(basket));
            }

            return NotFound();
        }

        [HttpPost]
        [Route("AddItemToBasket")]
        public ActionResult<ProductBasketReadDto> AddProductToBasket(AddProductToBasketDto productBasket)
        {
            var basketModel = _mapper.Map<ProductBasket>(productBasket);
            _basketService.AddProductToBasket(basketModel);

            var basketReadModel = _mapper.Map<ProductBasketReadDto>(basketModel);
            return Ok(basketReadModel);
        }

        [HttpDelete]
        [Route("DeleteFromBasket")]
        public ActionResult DeleteProduct(ProductBasketDeleteDto deleteDto)
        {
            var success = _basketService.RemoveItemFromBasket(deleteDto);

            if (!success)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPost]
        [Route("CreateBasket")]
        public ActionResult<BasketReadDto> CreateBasket(BasketCreateDto createDto)
        {
            var basketModel = _mapper.Map<Basket>(createDto);
            _basketService.CreateBasket(basketModel);

            var basketReadModel = _mapper.Map<BasketReadDto>(basketModel);
            return CreatedAtAction(nameof(CreateBasket), new {id = basketReadModel.Id}, basketReadModel);
        }

        [HttpGet]
        [Route("GetBasketById")]
        public ActionResult<BasketPriceDto> GetBasketById(int id) 
        { 
            var basket = _basketService.GetBasketById(id);

            return Ok(basket);
        }
    }
}
