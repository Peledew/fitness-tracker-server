using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Contracts.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Workouts, opt => opt.Ignore());
        }
    }
}
