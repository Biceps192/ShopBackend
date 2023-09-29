using AutoMapper;
using BackendApp.Dto;
using BackendApp.Models;

namespace BackendApp.Profiles
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderReadDto>();
            CreateMap<OrderCreateDto, Order>();
        }
    }
}
