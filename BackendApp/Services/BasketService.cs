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
        void UpdateBasket(Basket basket);
    }

    public class BasketService : IBasketService
    {
        private readonly IBasketRepo _basketRepo;

        public BasketService(IBasketRepo basketRepo)
        {
            _basketRepo = basketRepo;
        }

        public void CreateBasket(Basket basket)
        {
            _basketRepo.CreateBasket(basket);
            _basketRepo.SaveChanges();
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
