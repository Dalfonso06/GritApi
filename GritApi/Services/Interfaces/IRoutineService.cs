using GritApi.Models;

namespace GritApi.Services.Interfaces;

public interface IRoutineService
{
    Task<IEnumerable<Routine>> GetRoutines();
    Task<Routine> GetRoutine(int id);
    Task<bool> CreateRoutine(Routine model);
    Task<bool> UpdateRoutine(int id);
    Task<bool> DeleteRoutine(int id);
}