using AutoMapper;
using JobIn.Data.UnitOfWorks;
using JobIn.Entity.DTOs.Categories;
using JobIn.Entity.Entities;
using JobIn.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }


        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()     //Kategorileri döndüren servis
        {
            
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);

            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }
    }
}
