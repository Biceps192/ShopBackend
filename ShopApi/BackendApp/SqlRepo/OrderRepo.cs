using BackendApp.Data;
using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.SqlRepo
{
    public class OrderRepo : IOrderRepo
    {
        private readonly ShopContext _context;

        public OrderRepo(ShopContext shopContext)
        {
            _context = shopContext;
        }

        public void CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _context.Orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByBasketId(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.BasketId == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
