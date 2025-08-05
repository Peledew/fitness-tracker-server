using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Contracts.Profiles
{
    public class WorkoutProfile : Profile
    {
        public WorkoutProfile() 
        {
            CreateMap<Workout, WorkoutDto>();
            CreateMap<WorkoutDto, Workout>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
