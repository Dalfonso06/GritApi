using GritApi.Data;
using GritApi.Models;
using GritApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GritApi.Repositories.Implementations;

public class HashTagRepository<T> : IHashTagsRepository<HashTags>
{
    private readonly WorkoutContext _context;
    public HashTagRepository(WorkoutContext context)
    {
        _context = context;
    }

    public Task<bool> CreateHashTag(HashTags model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteHashTag(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<HashTags>> GetAllHashTags()
    {
        throw new NotImplementedException();
    }

    public Task<HashTags> GetHashTag(string name)
    {
        throw new NotImplementedException();
    }

    public Task<HashTags> GetHashTag(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateHashTag(HashTags model)
    {
        throw new NotImplementedException();
    }
}
