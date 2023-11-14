using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IBasketRepo
    {
        bool SaveChanges();
        Basket GetBasketByPublicUserId(int id);
        void CreateBasket(int publicUserId);
        void UpdateBasket(Basket basket);
        void AddItemToBasket(int productId, int basketId);
    }
}
