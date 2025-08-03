using FitnessTracker.API.Controllers.Abstract;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers
{
    [Route("api/workout-types")]
    public class WorkoutTypeConroller : BaseController<WorkoutType>
    {
        private readonly IWorkoutTypeService _workoutTypeService;

        public WorkoutTypeConroller(IWorkoutTypeService workoutTypeService)
            : base(workoutTypeService)
        {
            _workoutTypeService = workoutTypeService;
        }
    }
}
