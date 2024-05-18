using AutoMapper;
using JobIn.Entity.DTOs.Categories;
using JobIn.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {

        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }


    }
}
