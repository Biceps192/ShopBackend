using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IOrderRepo
    {
        bool SaveChanges();
        IEnumerable<Order> GetOrders();
        Order GetOrderByBasketId(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
