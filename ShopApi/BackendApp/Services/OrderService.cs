using BackendApp.Dto.OrderDto;
using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.Services
{
    public interface IOrderService
    {
        Order GetOrderByBasketId(int id);
        IEnumerable<Order> GetOrders();
        void CreateOrderByBasketId(OrderCreateDto dto);
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;

        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public void CreateOrderByBasketId(OrderCreateDto dto)
        {
            _orderRepo.CreateOrderByBasketId(dto);
        }

        public Order GetOrderByBasketId(int id)
        {
            return _orderRepo.GetOrderByBasketId(id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepo.GetOrders();
        }
    }
}
