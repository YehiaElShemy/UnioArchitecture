using Microsoft.EntityFrameworkCore;
using UnioArchitecture.Application.Contracts;
using UnioArchitecture.Context;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Infrastructure
{
    public class CategoryRepository<TEntity, Tid> :Repository<Category,int>,ICategoryRepositry 
    {
        private readonly UnionContext db;

        public CategoryRepository(UnionContext _db):base(_db) 
        {
            db = _db;
        }
        public Task<List<Category>> FillterByNameAsync()
        {
            throw new NotImplementedException();
        }
    }
}