using FitnessTracker.API.Controllers.Abstract;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [Route("api/workouts")]
    [Authorize]
    public class WorkoutController : BaseController<WorkoutDto>
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService workoutService)
            : base(workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet("by-user/{userId}")]
        public async Task<ActionResult<IEnumerable<WorkoutDto>>> GetAllByUserId(int userId)
        {
            return Ok(await _workoutService.GetAllByUserIdAsync(userId));
        }

        [HttpGet("stats/weekly")]
        public async Task<ActionResult<List<WeeklyWorkoutStatsDto>>> GetWeeklyStats(
            [FromQuery] int userId,
            [FromQuery] int month,
            [FromQuery] int year)
        {
            var stats = await _workoutService.GetWeeklyStatsAsync(userId, month, year);

            if (stats == null || !stats.Any())
                return NotFound("No workout stats found for the specified criteria.");

            return Ok(stats);
        }
    }
}
