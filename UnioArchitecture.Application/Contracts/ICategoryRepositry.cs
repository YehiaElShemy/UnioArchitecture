using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Application.Contracts
{
    public interface ICategoryRepositry : IRepository<Category, int>
    {
        Task<List<Category>> FillterByNameAsync();
    }
}
