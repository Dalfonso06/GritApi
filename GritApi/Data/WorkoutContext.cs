using Microsoft.EntityFrameworkCore;
using GritApi.Data;
using GritApi.Models;

namespace GritApi.Data;

public class WorkoutContext(IConfiguration configuration) : DbContext
{
    protected readonly IConfiguration Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("GritDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>()
            .OwnsMany(e => e.Reps , a =>
            {
                a.WithOwner().HasForeignKey("ExerciseId");
                a.HasKey("ExerciseId", "MinReps", "MaxReps");
            });
    }

    public DbSet<HashTags> HashTags => Set<HashTags>();
    public DbSet<Exercise> Exercise => Set<Exercise>();
    public DbSet<MuscleGroup> MuscleGroup => Set<MuscleGroup>();
    public DbSet<Routine> Routine => Set<Routine>();
    public DbSet<Workout> Workout => Set<Workout>();

}