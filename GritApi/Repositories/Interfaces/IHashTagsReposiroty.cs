using GritApi.Models;

namespace GritApi.Repositories.Interfaces
{
    public interface IHashTagsRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllHashTags();
        Task<T> GetHashTag(int id);
        Task<bool> CreateHashTag(T model);
        Task<bool> UpdateHashTag(T model);
        Task<bool> DeleteHashTag(int id);
    }
}