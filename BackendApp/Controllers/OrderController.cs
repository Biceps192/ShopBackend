using AutoMapper;
using BackendApp.Data;
using BackendApp.Dto;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace BackendApp.Controllers
{
    [Route("api/orders")]
    public class OrderController: ControllerBase
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepo orderRepo, IMapper mapper)
        {
            _orderRepo = orderRepo;
            _mapper = mapper;
        }

        [HttpGet("{PublicUserId}", Name = "GetOrderByUserId")]
        public ActionResult<OrderReadDto> GetOrderByUserId(int id)
        {
            var order = _orderRepo.GetOrderByUserId(id);
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
