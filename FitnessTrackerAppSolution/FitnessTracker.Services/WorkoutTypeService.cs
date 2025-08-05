using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstract;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services
{
    internal class WorkoutTypeService : BaseService<WorkoutType, WorkoutTypeDto>, IWorkoutTypeService
    {
        private readonly IWorkoutTypeRepository _workoutTypeRepository;

        public WorkoutTypeService
            (
                IWorkoutTypeRepository workoutTypeRepository,
                IMapper mapper
            )
            : base
                (
                    workoutTypeRepository,
                    mapper
                )
        {
            _workoutTypeRepository = workoutTypeRepository;
        }
    }
}
