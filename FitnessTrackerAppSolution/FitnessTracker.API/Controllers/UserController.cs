using FitnessTracker.API.Controllers.Abstract;
using FitnessTracker.Services.Abstractions;
using FitnessTracker.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [Route("api/users")]
    public class UserController : BaseController<UserDto>
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
            : base(userService)
        {
            _userService = userService;
        }
    }
}
