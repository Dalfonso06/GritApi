using GritApi.Models;

namespace GritApi.Repositories.Interfaces
{
    public interface IWorkoutRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllWorkouts();
        Task<T> GetWorkout(int id);
        Task<bool> CreateWorkout(T model);
        Task<bool> UpdateWorkout(T model);
        Task<bool> DeleteWorkout(int id);
    }
}