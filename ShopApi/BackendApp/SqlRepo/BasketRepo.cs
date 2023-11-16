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

        public void AddItemToBasket(int productId, int basketId)
        {
            var productBasket = new ProductBasket 
            { 
                ProductId = productId, 
                BasketId = basketId 
            };

            _context.ProductBasket.Add(productBasket);
            _context.SaveChanges();
        }

        public void CreateBasket(int publicUserId)
        {
            var basketRepo = _context.Baskets.FirstOrDefault(x => x.PublicUserId == publicUserId);

            if (basketRepo != null)
            {
                throw new ArgumentException($"User already has {nameof(Basket)}");          
            }
            var newBasket = new Basket
            {
                PublicUserId = publicUserId
            };

            _context.Baskets.Add(newBasket);
            _context.SaveChanges();
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
