using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IBasketRepo
    {
        bool SaveChanges();
        Basket GetBasketByPublicUserId(int id);
        void CreateBasket(Basket basket);
        void UpdateBasket(Basket basket);
    }
}
