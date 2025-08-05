using FitnessTracker.API.Controllers.Abstract;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [Route("api/workouts")]
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
