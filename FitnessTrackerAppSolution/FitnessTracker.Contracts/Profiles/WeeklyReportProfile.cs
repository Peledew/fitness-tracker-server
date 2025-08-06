using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Records;

namespace FitnessTracker.Contracts.Profiles
{
    public class WeeklyReportProfile : Profile
    {
        public WeeklyReportProfile()
        {
            CreateMap<WeeklyWorkoutStatsRecord, WeeklyWorkoutStatsDto>()
            .ForMember(dest => dest.TotalDuration,
                       opt => opt.MapFrom(src => TimeSpan.FromMinutes(src.TotalDurationMinutes)));
        }
    }
}
