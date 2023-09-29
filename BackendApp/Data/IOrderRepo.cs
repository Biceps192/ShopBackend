using BackendApp.Models;

namespace BackendApp.Data
{
    public interface IOrderRepo
    {
        bool SaveChanges();
        IEnumerable<Order> GetOrders();
        Order GetOrderByUserId(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
