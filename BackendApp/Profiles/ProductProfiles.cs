using AutoMapper;
using BackendApp.Dto;
using BackendApp.Models;

namespace BackendApp.Profiles
{
    public class ProductProfiles: Profile
    {
        public ProductProfiles()
        {
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}
