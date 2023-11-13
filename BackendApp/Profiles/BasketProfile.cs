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
            CreateMap<BasketCreateDto, Basket>();
            CreateMap<BasketUpdateDto, Basket>();
        }
    }
}
