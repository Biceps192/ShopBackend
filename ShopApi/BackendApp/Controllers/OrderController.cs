using AutoMapper;
using BackendApp.Dto;
using BackendApp.Dto.OrderDto;
using BackendApp.IRepo;
using BackendApp.Models;
using BackendApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetOrderByBasketId")]
        public ActionResult<OrderReadDto> GetOrderByBasketId(int basketId)
        {
            var order = _orderService.GetOrderByBasketId(basketId);
            if (order != null)
            {
                return Ok(_mapper.Map<OrderReadDto>(order));
            }
            return NotFound();
        }

        [HttpPost]
        [Route("CreateOrder")]
        public ActionResult<OrderReadDto> CreateOrder(OrderCreateDto dto)
        {
            var order = _mapper.Map<Order>(dto);
            _orderService.CreateOrderByBasketId(dto.BasketId);

            var orderReadModel = _mapper.Map<OrderReadDto>(order);
            return Ok(orderReadModel);
        }
    }
}
