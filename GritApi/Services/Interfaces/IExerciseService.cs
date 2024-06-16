using GritApi.Models;

namespace GritApi.Services.Interfaces;

public interface IExerciseService
{
    Task<IEnumerable<Exercise>> GetExercises();
    Task<Exercise> GetExercise(int id);
    Task<bool> CreateExercise(Exercise model);
    Task<bool> UpdateExercise(int id);
    Task<bool> DeleteExercise(int id);
}