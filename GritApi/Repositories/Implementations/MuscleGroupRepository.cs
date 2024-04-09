using GritApi.Data;
using GritApi.Models;
using GritApi.Repositories.Interfaces;

namespace GritApi.Repositories.Implementations;

public class MuscleGroupRepository<T> : IMuscleGroupRepository<MuscleGroup>
{
    private readonly WorkoutContext _context;
    public MuscleGroupRepository(WorkoutContext context)
    {
        _context = context;
    }

    public Task<bool> CreateMuscleGroup(MuscleGroup model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteMuscleGroup(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MuscleGroup>> GetAllMuscleGroups()
    {
        throw new NotImplementedException();
    }

    public Task<MuscleGroup> GetMuscleGroup(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateMuscleGroup(MuscleGroup model)
    {
        throw new NotImplementedException();
    }
}