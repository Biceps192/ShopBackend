using BackendApp.IRepo;
using BackendApp.Models;
using BackendApp.SqlRepo;

namespace BackendApp.Services
{
    public interface IBasketService
    {
        Basket GetBasketByPublicUserId(int id);
        bool SaveChanges();
        void CreateBasket(int publicUserId);
        void UpdateBasket(Basket basket);
        void AddProductToBasket(int productId, int basketId);
    }

    public class BasketService : IBasketService
    {
        private readonly IBasketRepo _basketRepo;

        public BasketService(IBasketRepo basketRepo)
        {
            _basketRepo = basketRepo;
        }

        public void AddProductToBasket(int productId, int basketId)
        {
            _basketRepo.AddItemToBasket(productId, basketId);
        }

        public void CreateBasket(int publicUserId)
        {
            _basketRepo.CreateBasket(publicUserId);
        }

        public Basket GetBasketByPublicUserId(int id)
        {
            return _basketRepo.GetBasketByPublicUserId(id);
        }

        public bool SaveChanges()
        {
            return _basketRepo != null;
        }

        public void UpdateBasket(Basket basket)
        {
            _basketRepo.UpdateBasket(basket);
        }
    }
}
