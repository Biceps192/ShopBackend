using AutoMapper;
using BackendApp.Dto.Category;
using BackendApp.Models;

namespace BackendApp.Profiles
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryReadDto>();
            CreateMap<Subcategory, SubcategoryReadDto>();
            CreateMap<SubcategoryCreateDto, Subcategory>();
        }
    }
}
