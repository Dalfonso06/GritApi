using GritApi.Models;

namespace GritApi.Services.Interfaces;

public interface IWorkoutService
{
    Task<IEnumerable<Workout>> GetWorkouts();
    Task<Workout> GetWorkout(int id);
    Task<bool> CreateWorkout(Workout model);
    Task<bool> UpdateWorkout(int id);
    Task<bool> DeleteWorkout(int id);
}