﻿using BackendApp.Dto.BasketDto;
using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IBasketRepo
    {
        bool SaveChanges();
        Basket GetBasketByPublicUserId(int id);
        void CreateBasket(Basket basket);
        void AddItemToBasket(ProductBasket productBasket);
        BasketPriceDto GetBasket(int id);
        bool RemoveItemFromBasket(ProductBasketDeleteDto productBasketDeleteDto);
    }
}
