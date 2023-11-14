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
        public ActionResult<BasketReadDto> AddProductToBasket([FromBody] AddProductToBasketDto dto)
        {
            var basketModel = _mapper.Map<Basket>(dto);
            _basketService.AddProductToBasket(dto.ProductId, dto.BasketId);

            var basketReadModel = _mapper.Map<BasketReadDto>(basketModel);
            return CreatedAtAction(nameof(AddProductToBasket), new {id = basketReadModel.Id }, basketReadModel);
        }

        [HttpPatch]
        public ActionResult UpdateBasket(int id, BasketUpdateDto basketUpdate)
        {
            var basketModelFromRepo = _basketService.GetBasketByPublicUserId(id);
            if (basketModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(basketUpdate, basketModelFromRepo);
            _basketService.UpdateBasket(basketModelFromRepo);
            _basketService.SaveChanges();

            return Ok();
        }

        [HttpPost]
        [Route("CreateBasket")]
        public ActionResult<BasketReadDto> CreateBasket(BasketCreateDto createDto)
        {
            try
            {
                _basketService.CreateBasket(createDto.PublicUserId);
                return Ok(new {message = "Basket created"});
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }

        }
    }
}
