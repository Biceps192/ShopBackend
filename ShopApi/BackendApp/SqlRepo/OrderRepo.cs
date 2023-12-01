using BackendApp.Data;
using BackendApp.Dto.OrderDto;
using BackendApp.IRepo;
using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.SqlRepo
{
    public class OrderRepo : IOrderRepo
    {
        private readonly ShopContext _context;

        public OrderRepo(ShopContext shopContext)
        {
            _context = shopContext;
        }

        public void CreateOrderByBasketId(int basketId)
        {
            var basket = _context.Baskets.FirstOrDefault(x => x.Id == basketId);

            if (basket != null)
            {
                var newOrder = new Order
                {
                    BasketId = basket.Id,
                    Price = basket.Price,
                    OrderDate = DateTime.UtcNow
                };

                _context.Add(newOrder);
                _context.SaveChanges();
            }

            var productBasket = _context.ProductBasket.Where(x => x.BasketId == basketId).ExecuteDelete();
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
    }
}
