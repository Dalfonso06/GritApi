using GritApi.Models;

namespace GritApi.Services.Interfaces;

public interface IMuscleGroupService
{
    Task<IEnumerable<MuscleGroup>> GetMuscleGroups();
    Task<MuscleGroup> GetMuscleGroup(int id);
    Task<bool> CreateMuscleGroup(MuscleGroup model);
    Task<bool> UpdateMuscleGroup(int id);
    Task<bool> DeleteMuscleGroup(int id);
}