using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnioArchitecture.Application.Contracts;
using UnioArchitecture.DTO;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepositry categoryRepositry;
        public CategoryService(ICategoryRepositry _categoryRepositry)
        {
            categoryRepositry = _categoryRepositry;
        }
        public async Task<CreateUpdateCategoryDTO> CreateAsync(CreateUpdateCategoryDTO category)
        {
            Category category1 = new Category
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                parentId = category.parentId
            };
            var result = await categoryRepositry.CreateAsync(category1);
            return new CreateUpdateCategoryDTO
            { Id = result.Id, Name = result.Name, Description = result.Description, parentId = result.parentId };
        }
        public async Task<List<GetAllCategoryDTO>> GetAllCategoriesPaginationAsync(int items, int pageNumber)
        {
            var categories = await categoryRepositry.GetAllAsync();
            var pagenationList = categories.Skip(items * (pageNumber - 1)).Take(items)
                .Select(a => new GetAllCategoryDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                }).ToList();

            return pagenationList;
        }
    }
}
