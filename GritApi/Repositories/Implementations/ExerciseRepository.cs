using GritApi.Data;
using GritApi.Models;
using GritApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GritApi.Repositories.Implementations;

public class ExerciseRepository<T> : IExerciseRepository<Exercise>
{
    private readonly WorkoutContext _context;
    public ExerciseRepository(WorkoutContext context)
    {
        _context = context;
    }

    public Task<bool> CreateExercise(Exercise model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteExercise(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Exercise>> GetAllExercises()
    {
        throw new NotImplementedException();
    }

    public Task<Exercise> GetExercise(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateExercise(Exercise model)
    {
        throw new NotImplementedException();
    }
}