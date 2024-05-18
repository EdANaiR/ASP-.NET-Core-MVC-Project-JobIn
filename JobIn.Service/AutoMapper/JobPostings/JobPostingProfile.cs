using AutoMapper;
using JobIn.Entity.DTOs.JobPostings;
using JobIn.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Service.AutoMapper.JobPostings
{
    public class JobPostingProfile : Profile
    {
        public JobPostingProfile()
        {
            CreateMap<JobPostingDto,JobPosting>().ReverseMap();
        }
    }
}
