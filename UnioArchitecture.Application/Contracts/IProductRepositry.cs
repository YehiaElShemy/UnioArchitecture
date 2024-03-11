using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Application.Contracts
{
    public interface IProductRepositry: IRepository<Product, int>
    {
        Task<List<Product>> FillterByNameAsync();
        Task<List<Product>> FillterByPriceAsync();
    }
}
