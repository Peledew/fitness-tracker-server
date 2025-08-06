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
