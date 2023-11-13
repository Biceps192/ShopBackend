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
        public ActionResult<BasketReadDto> CreateBasket(BasketCreateDto basketCreatDto)
        {
            var basketModel = _mapper.Map<Basket>(basketCreatDto);
            _basketService.CreateBasket(basketModel);

            var basketReadModel = _mapper.Map<BasketReadDto>(basketModel);
            return CreatedAtAction(nameof(CreateBasket), new {id = basketReadModel.Id }, basketReadModel);
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
    }
}
