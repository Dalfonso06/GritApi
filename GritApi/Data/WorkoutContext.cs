using Microsoft.EntityFrameworkCore;
using GritApi.Data;
using GritApi.Models;

namespace GritApi.Data;

public class WorkoutContext : DbContext
{
    public WorkoutContext (DbContextOptions<WorkoutContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Category => Set<Category>();
    public DbSet<Exercise> Exercise => Set<Exercise>();
    public DbSet<MuscleGroup> MuscleGroup => Set<MuscleGroup>();
    public DbSet<Routine> Routine => Set<Routine>();
    public DbSet<Workout> Workout => Set<Workout>();

}