using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Application.Contracts
{
    public interface IRepository<TEntity,Tid> //where TEntity: class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Tid id);
        Task<TEntity> CreateAsync(TEntity category);
        Task<bool> UpdateAsync(TEntity category);
        Task<bool> DeleteAsync(Tid id);
        Task<int> SaveChangesAsync();
    }
}
