using AutoMapper;
using BackendApp.Dto.UserDto;
using BackendApp.Models;
using BackendApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BackendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController: ControllerBase
    {
        private readonly IAuthService _service;
        private readonly IMapper _mapper;

        public AuthenticationController(IAuthService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("register")]
        public ActionResult<UserReadDto> Register(UserCreateDto dto)
        {
            _service.CreatePasswordHash(dto.Password, out byte[] passwordHash, out byte[] passwordSalt);

            User user = new User
            {
                Username = dto.Username,
                Email = dto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _service.CreateUser(user);

            return Ok(_mapper.Map<UserReadDto>(user));
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<UserReadDto> Login(UserCreateDto dto)
        {
            var user = _service.GetUserByEmail(dto.Email);

            if (user != null && user.Username != dto.Username)
            {
                return NotFound("User not found");
            }
            else if (!_service.VerifyPasswordHash(dto.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Wrong password");
            }

            string token = _service.CreateToken(user);

            return Ok(token);
        }
    }
}
