using AutoMapper;
using BackendApp.Dto;
using BackendApp.Dto.OrderDto;
using BackendApp.IRepo;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepo orderRepo, IMapper mapper)
        {
            _orderRepo = orderRepo;
            _mapper = mapper;
        }

        [HttpGet("GetOrderByUserId/{PublicUserId}")]
        public ActionResult<OrderReadDto> GetOrderByUserId(int id)
        {
            var order = _orderRepo.GetOrderByBasketId(id);
            if (order != null)
            {
                return Ok(_mapper.Map<OrderReadDto>(order));
            }
            return NotFound();
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderReadDto>> GetOrders()
        {
            var orders = _orderRepo.GetOrders();

            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orders));
        }

        [HttpPost]
        public ActionResult<OrderReadDto> CreateOrder(OrderCreateDto order)
        {
            var orderModel = _mapper.Map<Order>(order);
            _orderRepo.CreateOrder(orderModel);
            _orderRepo.SaveChanges();

            var orderReadDto = _mapper.Map<OrderReadDto>(orderModel);

            return CreatedAtRoute(nameof(GetOrderByUserId), new {Id = orderReadDto.Id}, orderReadDto);
        }
    }
}
