using GritApi.Data;
using GritApi.Models;
using GritApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

    public async Task<IEnumerable<MuscleGroup>> GetAllMuscleGroups()
    {
        return await _context.MuscleGroup.ToListAsync();
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