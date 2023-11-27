using BackendApp.Data;
using BackendApp.Dto.BasketDto;
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

        public void AddItemToBasket(ProductBasket productBasketDto)
        {
            var productBasket = new ProductBasket();

            var existingProductInBasket = _context.ProductBasket
                .FirstOrDefault(x => x.BasketId == productBasketDto.BasketId && 
                x.ProductId == productBasketDto.ProductId);

            if (existingProductInBasket != null)
            {
                existingProductInBasket.Quantity++;
                productBasket = existingProductInBasket;
            }
            else
            {
                var newProductBasket = new ProductBasket
                {
                    ProductId = productBasketDto.ProductId,
                    BasketId = productBasketDto.BasketId,
                    Quantity = 1
                };

                productBasket = newProductBasket;

                _context.ProductBasket.Add(newProductBasket);
            }

            _context.SaveChanges();

            var basket = _context.Baskets.FirstOrDefault(x => x.Id == productBasket.BasketId);
            if (basket != null)
            {
                decimal newPrice = _context.ProductBasket
                    .Where(x => x.BasketId == productBasket.BasketId)
                    .Select(x => x.Product.Price * x.Quantity)
                    .Sum();

                basket.Price = newPrice;
                
                _context.SaveChanges();
            }
        }
 
        public void CreateBasket(Basket basket)
        {
            var basketRepo = _context.Baskets.FirstOrDefault(x => x.PublicUserId == basket.PublicUserId);

            if (basketRepo != null)
            {
                throw new ArgumentException($"User already has {nameof(Basket)}");          
            }
            var newBasket = new Basket
            {
                PublicUserId = basket.PublicUserId
            };

            _context.Baskets.Add(newBasket);
            _context.SaveChanges();

            basket.Id = newBasket.Id;
        }

        public Basket GetBasketByPublicUserId(int id)
        {
            return _context.Baskets.FirstOrDefault(x => x.PublicUserId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePrice(Basket basket)
        {
            throw new NotImplementedException();
        }
    }
}
