using GritApi.Models;
using GritApi.Data;
using GritApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GritApi.Repositories.Implementations;

public class RoutineRepository<T> : IRoutineRepository<Routine>
{
    private readonly WorkoutContext _context;
    public RoutineRepository(WorkoutContext context)
    {
        _context = context;
    }
    public Task<bool> CreateRoutine(Routine model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteRoutine(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Routine>> GetAllRoutines()
    {
        throw new NotImplementedException();
    }

    public Task<Routine> GetRoutine(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateRoutine(Routine model)
    {
        throw new NotImplementedException();
    }
}