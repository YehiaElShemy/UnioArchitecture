using Microsoft.EntityFrameworkCore;
using UnioArchitecture.Application.Contracts;
using UnioArchitecture.Context;

namespace UnioArchitecture.Infrastructure
{
    public class Repository<TEntity, Tid> : IRepository<TEntity, Tid> where TEntity : class
    {
        private readonly UnionContext db;
        private readonly DbSet<TEntity> _DbSet;

        public Repository(UnionContext _db)
        {
            db = _db;
            _DbSet = db.Set<TEntity>();
        }
        public async Task<TEntity> CreateAsync(TEntity TEntity)
        {
            return (await _DbSet.AddAsync(TEntity)).Entity;
        }

        public async Task<bool> DeleteAsync(TEntity TEntity)
        {
            var result = await Task.FromResult(_DbSet.Remove(TEntity));
            return result is not null ? true : false;
        }
        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            return await Task.FromResult(_DbSet.Select(T => T));
        }
        public async Task<TEntity> GetByIdAsync(Tid Tid)
        {
            return await _DbSet.FindAsync(Tid);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await db.SaveChangesAsync();
        }
        public async Task<bool> UpdateAsync(TEntity TEntity)
        {
            var result = await Task.FromResult(_DbSet.Update(TEntity));
            return result is not null ? true : false;
        }
    }
}