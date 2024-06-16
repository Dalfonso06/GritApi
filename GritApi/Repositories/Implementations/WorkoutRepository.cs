using GritApi.Models;
using GritApi.Data;
using GritApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GritApi.Repositories.Implementations;

public class WorkoutRepository<T> : IWorkoutRepository<Workout>
{
    private readonly WorkoutContext _context;
    public WorkoutRepository(WorkoutContext context)
    {
        _context = context;
    }

    public Task<bool> CreateWorkout(Workout model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteWorkout(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Workout>> GetAllWorkouts()
    {
        throw new NotImplementedException();
    }

    public Task<Workout> GetWorkout(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateWorkout(Workout model)
    {
        throw new NotImplementedException();
    }
}