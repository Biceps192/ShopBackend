using BackendApp.Dto.BasketDto;
using BackendApp.IRepo;
using BackendApp.Models;
using BackendApp.SqlRepo;

namespace BackendApp.Services
{
    public interface IBasketService
    {
        Basket GetBasketByPublicUserId(int id);
        bool SaveChanges();
        void CreateBasket(Basket basket);
        void AddProductToBasket(ProductBasket productBasket);
    }

    public class BasketService : IBasketService
    {
        private readonly IBasketRepo _basketRepo;

        public BasketService(IBasketRepo basketRepo)
        {
            _basketRepo = basketRepo;
        }

        public void AddProductToBasket(ProductBasket productBasket)
        {
            _basketRepo.AddItemToBasket(productBasket);
        }

        public void CreateBasket(Basket basket)
        {
            _basketRepo.CreateBasket(basket);
        }

        public Basket GetBasketByPublicUserId(int id)
        {
            return _basketRepo.GetBasketByPublicUserId(id);
        }

        public bool SaveChanges()
        {
            return _basketRepo.SaveChanges();
        }
    }
}
