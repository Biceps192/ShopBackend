using BackendApp.Models;

namespace BackendApp.Data
{
    public interface IBasketRepo
    {
        Basket GetBasketByPublicUserId(int id);
        void CreateBasket(Basket basket);
        void UpdateBasket(Basket basket);
    }
}
