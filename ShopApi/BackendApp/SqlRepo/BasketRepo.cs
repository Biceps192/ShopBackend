using BackendApp.Data;
using BackendApp.Dto.BasketDto;
using BackendApp.IRepo;
using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

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
            var basket = _context.Baskets.FirstOrDefault(x => x.Id == productBasketDto.BasketId);
            var existingProductInBasket = _context.ProductBasket
                .FirstOrDefault(x => x.BasketId == productBasketDto.BasketId && 
                x.ProductId == productBasketDto.ProductId);
            var product = _context.Products.FirstOrDefault(x => x.Id == productBasketDto.ProductId);

            if (product.Count == 0)
            {
                throw new Exception("Out Of Stock");
            }
            else if (productBasketDto.Quantity > product.Count)
            {
                throw new Exception($"Sorry, we only have {product.Count} items");
            }
            else
            {
                if (existingProductInBasket != null)
                {
                    var newQuantity = existingProductInBasket.Quantity + productBasketDto.Quantity;
                    existingProductInBasket.Quantity = newQuantity;
                    productBasket = existingProductInBasket;
                }
                else
                {
                    var newProductBasket = new ProductBasket
                    {
                        ProductId = productBasketDto.ProductId,
                        BasketId = productBasketDto.BasketId,
                        Quantity = productBasketDto.Quantity
                    };

                    productBasket = newProductBasket;

                    _context.ProductBasket.Add(newProductBasket);
                }

                _context.SaveChanges();


                if (basket != null)
                {
                    decimal newPrice = _context.ProductBasket
                        .Where(x => x.BasketId == productBasket.BasketId)
                        .Select(x => x.Product.Price * x.Quantity)
                        .Sum();

                    basket.Price = newPrice;

                    _context.SaveChanges();
                }

                var newCount = product.Count - productBasketDto.Quantity;
                product.Count = newCount;

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

        public BasketPriceDto GetBasket(int id)
        {
            var basket = _context.Baskets.FirstOrDefault(x => x.Id == id);

            var basketPricedto = new BasketPriceDto
            {
                Price = basket.Price
            };

            return basketPricedto;
        }

        public Basket GetBasketByPublicUserId(int id)
        {
            return _context.Baskets.FirstOrDefault(x => x.PublicUserId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
