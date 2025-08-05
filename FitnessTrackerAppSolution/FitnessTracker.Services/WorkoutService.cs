using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstract;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services
{
    internal class WorkoutService : BaseService<Workout, WorkoutDto>, IWorkoutService
    {
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IWorkoutTypeService _workoutTypeService;

        public WorkoutService
            (
                IWorkoutRepository workoutRepository,
                IMapper mapper,
                IWorkoutTypeService workoutTypeService
            ) 
            :base(workoutRepository, mapper)
        {
            _workoutRepository = workoutRepository;
            _workoutTypeService = workoutTypeService;
        }

        public override async Task<WorkoutDto> AddAsync(WorkoutDto dto)
        {
            var entity = _mapper.Map<Workout>(dto);
            var typeDto = await _workoutTypeService.GetByIdAsync(dto.WorkoutTypeId.Value);

            entity.Type = _mapper.Map<WorkoutType>(typeDto);

            await _workoutRepository.AddAsync(entity);
            return _mapper.Map<WorkoutDto>(entity);
        }
    }
}
