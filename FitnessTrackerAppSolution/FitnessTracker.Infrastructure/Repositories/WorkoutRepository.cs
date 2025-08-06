using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Domain.Records;
using FitnessTracker.Infrastructure.Context;
using FitnessTracker.Infrastructure.Repositories.Abstract;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Infrastructure.Repositories
{
    internal class WorkoutRepository : BaseRepository<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<WeeklyWorkoutStatsRecord>> GetWeeklyStatsAsync(int userId, int month, int year)
        {
            var sql = @"
                SELECT 
                    DATEPART(WEEK, w.WorkoutDate) AS WeekNumber,
                    COUNT(*) AS WorkoutCount,
                    AVG(CAST(w.DifficultyLevel AS FLOAT)) AS AverageDifficultyLevel,
                    AVG(CAST(w.PostWorkoutFatigueLevel AS FLOAT)) AS AveragePostWorkoutFatigueLevel,
                    SUM(DATEDIFF(MINUTE, 0, w.Duration)) AS TotalDurationMinutes
                FROM Workouts w
                WHERE 
                    w.UserId = @userId AND 
                    MONTH(w.WorkoutDate) = @month AND 
                    YEAR(w.WorkoutDate) = @year
                GROUP BY DATEPART(WEEK, w.WorkoutDate)
                ORDER BY WeekNumber;
            ";

            var parameters = new[]
            {
                new SqlParameter("@userId", userId),
                new SqlParameter("@month", month),
                new SqlParameter("@year", year),
            };

            return await _context.Database
                .SqlQueryRaw<WeeklyWorkoutStatsRecord>(sql, parameters)
                .ToListAsync(); ;
        }
    }
}
