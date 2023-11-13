using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.Services
{
    public interface IOrderService
    {
        Order GetOrderByBasketId(int id);
        IEnumerable<Order> GetOrders();
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;

        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public void CreateOrder(Order order)
        {
            _orderRepo.CreateOrder(order);
        }

        public void DeleteOrder(Order order)
        {
            _orderRepo.DeleteOrder(order);
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
