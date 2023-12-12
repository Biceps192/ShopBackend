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

        public void CreateOrderByBasketId(OrderCreateDto dto)
        {
            var basket = _context.Baskets.FirstOrDefault(x => x.Id == dto.BasketId);

            if (basket != null)
            {
                var newOrder = new Order
                {
                    BasketId = basket.Id,
                    Price = basket.Price,
                    OrderDate = DateTime.UtcNow,
                    Address = dto.Address
                };

                _context.Add(newOrder);
                _context.SaveChanges();
            }

            var productBasket = _context.ProductBasket.Where(x => x.BasketId == dto.BasketId).ExecuteDelete();

            basket.Price = 0;
            _context.SaveChanges();
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
