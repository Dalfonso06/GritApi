namespace GritApi.Repositories.Interfaces;

public interface IRoutineRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllRoutines();
    Task<T> GetRoutine(int id);
    Task<bool> CreateRoutine(T model);
    Task<bool> UpdateRoutine(T model);
    Task<bool> DeleteRoutine(int id);
}