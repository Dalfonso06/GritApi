using GritApi.Models;
using GritApi.Services.Interfaces;

namespace GritApi.Services.Implementations;

public class ExerciseService : IExerciseService
{
    public Task<bool> CreateExercise(Exercise model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteExercise(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Exercise> GetExercise(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Exercise>> GetExercises()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateExercise(int id)
    {
        throw new NotImplementedException();
    }
}