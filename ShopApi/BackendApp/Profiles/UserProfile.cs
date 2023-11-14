using AutoMapper;
using BackendApp.Dto.BasketDto;
using BackendApp.Dto.UserDto;
using BackendApp.Models;

namespace BackendApp.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<PublicUser, PublicUserReadDto>();
            CreateMap<PublicUserCreateDto, PublicUser>();
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
        }
    }
}
