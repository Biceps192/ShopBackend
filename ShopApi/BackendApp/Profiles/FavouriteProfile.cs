using AutoMapper;
using BackendApp.Dto.ProductDto;
using BackendApp.Models;

namespace BackendApp.Profiles
{
    public class FavouriteProfile: Profile
    {
        public FavouriteProfile()
        {
            CreateMap<Favourite, FavouritesByUserIdReadDto>();
        }
    }
}
