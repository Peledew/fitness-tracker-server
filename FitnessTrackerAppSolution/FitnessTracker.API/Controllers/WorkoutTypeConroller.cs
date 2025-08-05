using FitnessTracker.API.Controllers.Abstract;
using FitnessTracker.Services.Abstractions;
using FitnessTracker.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [Route("api/workout-types")]
    public class WorkoutTypeConroller : BaseController<WorkoutTypeDto>
    {
        private readonly IWorkoutTypeService _workoutTypeService;

        public WorkoutTypeConroller(IWorkoutTypeService workoutTypeService)
            : base(workoutTypeService)
        {
            _workoutTypeService = workoutTypeService;
        }
    }
}
