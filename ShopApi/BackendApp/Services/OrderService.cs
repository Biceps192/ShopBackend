using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.Services
{
    public interface IOrderService
    {
        Order GetOrderByBasketId(int id);
        IEnumerable<Order> GetOrders();
        void UpdateOrder(Order order);
        void CreateOrderByBasketId(int basketId);
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;

        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public void CreateOrderByBasketId(int basketId)
        {
            _orderRepo.CreateOrderByBasketId(basketId);
        }

        public Order GetOrderByBasketId(int id)
        {
            return _orderRepo.GetOrderByBasketId(id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepo.GetOrders();
        }

        public void UpdateOrder(Order order)
        {
            _orderRepo.UpdateOrder(order);
        }
    }
}
