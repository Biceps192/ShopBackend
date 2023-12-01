using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IOrderRepo
    {
        bool SaveChanges();
        IEnumerable<Order> GetOrders();
        Order GetOrderByBasketId(int basketId);
        void CreateOrderByBasketId(int basketId);
    }
}
