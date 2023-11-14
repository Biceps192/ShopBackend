using AutoMapper;
using BackendApp.Dto.BasketDto;
using BackendApp.Models;

namespace BackendApp.Profiles
{
    public class BasketProfile: Profile
    {
        public BasketProfile()
        {
            CreateMap<Basket, BasketReadDto>();
            CreateMap<AddProductToBasketDto, Basket>();
            CreateMap<BasketUpdateDto, Basket>();
        }
    }
}
