using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthorizationService _authorizationService;
        public AuthenticationController(IUserService userService, IAuthorizationService authorizationService)
        {
            _userService = userService;
            _authorizationService = authorizationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LogInDto loginData)
        {
            if (loginData == null)
                return BadRequest();

            var user = await _userService.AuthenticateUserAsync(loginData);

            if (user == null)
                return NotFound(new { Message = "User not found!" });

            return Ok(_authorizationService.ManageTokens(user));
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] UserDto newUser)
        {
            return Created("", await _userService.AddAsync(newUser));
        }
    }
}
