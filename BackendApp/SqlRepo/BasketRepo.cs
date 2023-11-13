using BackendApp.Data;
using BackendApp.IRepo;
using BackendApp.Models;

namespace BackendApp.SqlRepo
{
    public class BasketRepo : IBasketRepo
    {
        private readonly ShopContext _context;

        public BasketRepo(ShopContext context)
        {
            _context = context;
        }
        public void CreateBasket(Basket basket)
        {
            var basketRepo = _context.Baskets.FirstOrDefault(x => x.PublicUserId == basket.PublicUserId);

            if (basketRepo == null)
            {
                _context.Baskets.Add(basket);            
            }
            else
            {
                throw new ArgumentException($"User with {basket.PublicUserId} already has {nameof(Basket)}");
            }
        }

        public Basket GetBasketByPublicUserId(int id)
        {
            return _context.Baskets.FirstOrDefault(x => x.PublicUserId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateBasket(Basket basket)
        {
            
        }
    }
}
