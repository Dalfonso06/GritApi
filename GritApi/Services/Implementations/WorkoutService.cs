using GritApi.Models;
using GritApi.Services.Interfaces;

namespace GritApi.Services.Implementations;

public class WorkoutService : IWorkoutService
{
    public Task<bool> CreateWorkout(Workout model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteWorkout(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Workout> GetWorkout(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Workout>> GetWorkouts()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateWorkout(int id)
    {
        throw new NotImplementedException();
    }
}