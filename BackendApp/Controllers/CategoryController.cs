using AutoMapper;
using BackendApp.Dto.Category;
using BackendApp.Models;
using BackendApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController: ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Category> GetAllCategories()
        {
            var categories = _service.GetAllCategories();

            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(categories));
        }

        [Route("/GetAllSubcategoriesByCategory")]
        [HttpGet]
        public ActionResult<Subcategory> GetAllSubcategoriesByCategory(int id)
        {
            var subcategories = _service.GetAllSubcategoriesByCategory(id);

            return Ok(_mapper.Map<IEnumerable<SubcategoryReadDto>>(subcategories));
        }

        [HttpPost]
        public ActionResult<SubcategoryReadDto> CreateSubcategory(SubcategoryCreateDto subcategory)
        {
            var subcategoryModel = _mapper.Map<Subcategory>(subcategory);
            _service.CreateSubcategory(subcategoryModel);

            var subcategoryReadDto = _mapper.Map<SubcategoryReadDto>(subcategoryModel);

            return Ok(subcategoryReadDto);
        }
    }
}
