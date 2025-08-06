using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class AuthorizationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthorizationService _authorizationService;
        public AuthorizationController(IUserService userService, IAuthorizationService authorizationService)
        {
            _userService = userService;
            _authorizationService = authorizationService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LogInDto loginData)
        {
            if (loginData == null)
                return BadRequest();

            var user = await _userService.AuthenticateUserAsync(loginData);

            if (user == null)
                return NotFound(new { Message = "User not found!" });

            return Ok(_authorizationService.ManageTokens(user));
        }
    }
}
