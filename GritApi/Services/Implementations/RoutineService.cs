using GritApi.Models;
using GritApi.Repositories.Interfaces;
using GritApi.Services.Interfaces;

namespace GritApi.Services.Implementations;

public class RoutineService : IRoutineService
{
    private readonly IRoutineRepository<Routine> _routineRepository;

    public RoutineService(IRoutineRepository<Routine> routineRepository)
    {
        _routineRepository = routineRepository;
    }

    public Task<bool> CreateRoutine(Routine model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteRoutine(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Routine> GetRoutine(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Routine>> GetRoutines()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateRoutine(int id)
    {
        throw new NotImplementedException();
    }
}