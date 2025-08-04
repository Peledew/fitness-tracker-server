using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Contracts.Profiles
{
    public class WorkoutTypeProfile : Profile
    {
        public WorkoutTypeProfile() 
        { 
            CreateMap<WorkoutType, WorkoutDto>().ReverseMap();
        }
    }
}
