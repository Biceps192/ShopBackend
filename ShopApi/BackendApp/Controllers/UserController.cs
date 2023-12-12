using AutoMapper;
using BackendApp.Dto.UserDto;
using BackendApp.Models;
using BackendApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<PublicUserReadDto> CreatePublicUser(PublicUserCreateDto createDto)
        {
            var publicUserModel = _mapper.Map<PublicUser>(createDto);
            _userService.CreatePublicUser(publicUserModel);

            var publicUserReadModel = _mapper.Map<PublicUserReadDto>(publicUserModel);
            return CreatedAtAction(nameof(CreatePublicUser), new { id = publicUserReadModel.Id }, publicUserReadModel);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<PublicUserReadDto>> GetPublicUserById(int id)
        {
            var publicUser = await _userService.GetPublicUserById(id);

            if (publicUser == null)
            {
                throw new ArgumentException($"User {publicUser.Email} not found");
            }

            return Ok(_mapper.Map<PublicUserReadDto>(publicUser));
        }

        [HttpGet]
        public ActionResult<PublicUserReadDto> GetAllPublicUsers()
        {
            var publicUsers = _userService.GetAllPublicUsers();

            return Ok(publicUsers);
        }

        [HttpGet]
        [Route("CheckPublicUser")]
        public ActionResult<PublicUserReadDto> CheckPublicUser(string email)
        {
            var publicUser = _userService.GetPublicUserByEmail(email);

            return Ok(publicUser);
        }

        [HttpGet]
        [Route("GetByPublicUserId")]
        public ActionResult<User> GetByPublicUserId(int id)
        {
            var user = _userService.GetUserByPublicUserId(id);

            return Ok(user);
        }
    }
}
