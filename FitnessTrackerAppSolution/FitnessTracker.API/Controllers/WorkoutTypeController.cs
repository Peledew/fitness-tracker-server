using FitnessTracker.API.Controllers.Abstract;
using FitnessTracker.Services.Abstractions;
using FitnessTracker.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [Route("api/workout-types")]
    public class WorkoutTypeController : BaseController<WorkoutTypeDto>
    {
        private readonly IWorkoutTypeService _workoutTypeService;

        public WorkoutTypeController(IWorkoutTypeService workoutTypeService)
            : base(workoutTypeService)
        {
            _workoutTypeService = workoutTypeService;
        }
    }
}
