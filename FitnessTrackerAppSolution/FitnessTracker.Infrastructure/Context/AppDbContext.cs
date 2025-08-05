using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<WorkoutType> WorkoutTypes { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
            .HasMany(u => u.Workouts)
            .WithOne(w => w.User)
            .HasForeignKey(w => w.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Workout>()
            .HasOne(w => w.Type)
            .WithMany()
            .HasForeignKey(w => w.WorkoutTypeId)
            .OnDelete(DeleteBehavior.SetNull);
        }
    }
}


//TODO: remove those comments

//MIGRATION: dotnet ef migrations add 1_FirstMigration --startup-project ../FitnessTracker.API --project .

//APPLY: dotnet ef database update --startup-project ../FitnessTracker.API --project .