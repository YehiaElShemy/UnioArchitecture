using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Application.Contracts
{
    public interface IImageRepositry:IRepository<Image,int>
    {
        Task<List<Image>> FillterByNameAsync();

    }
}
