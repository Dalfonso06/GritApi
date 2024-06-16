
using GritApi.Models;

namespace GritApi.Repositories.Interfaces;

public interface IExerciseRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllExercises();
    Task<T> GetExercise(int id);
    Task<bool> CreateExercise(T model);
    Task<bool> UpdateExercise(T model);
    Task<bool> DeleteExercise(int id);
}
