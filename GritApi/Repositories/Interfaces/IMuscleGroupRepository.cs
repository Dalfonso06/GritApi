
using GritApi.Models;

namespace GritApi.Repositories.Interfaces;

public interface IMuscleGroupRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllMuscleGroups();
    Task<T> GetMuscleGroup(int id);
    Task<bool> CreateMuscleGroup(T model);
    Task<bool> UpdateMuscleGroup(T model);
    Task<bool> DeleteMuscleGroup(int id);
}