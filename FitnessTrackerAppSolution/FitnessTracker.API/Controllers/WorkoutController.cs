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
    }
}
