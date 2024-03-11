using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnioArchitecture.DTO;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Application.Services
{
    public interface ICategoryService
    {
        Task<CreateUpdateCategoryDTO> CreateAsync(CreateUpdateCategoryDTO category);
        Task<List<GetAllCategoryDTO>> GetAllCategoriesPaginationAsync(int items,int pageNumber);
    }
}
