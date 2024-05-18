using JobIn.Entity.Entities;
using JobIn.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobIn.Data.UnitOfWorks;
using JobIn.Entity.DTOs.JobPostings;
using AutoMapper;

namespace JobIn.Service.Services.Concrete
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public JobPostingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreateJobPostingAsync(JobPostingAddDto jobPostingAddDto)
        {
            var userId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C");
            var jobPosting = new JobPosting
            {
                Title = jobPostingAddDto.Title,
                CreatedBy = jobPostingAddDto.CreatedBy,  
                JobType= jobPostingAddDto.JobType,
                CategoryId = jobPostingAddDto.CategoryId,
                UserId = userId
                
            };

            await unitOfWork.GetRepository<JobPosting>().AddAsync(jobPosting);
            await unitOfWork.SaveAsync();

        }

        public async Task<List<JobPostingDto>> GetAllJobPostingsWithCayegoryNonDeleteAsync()
        {
             
            var jobPostings = await unitOfWork.GetRepository<JobPosting>().GetAllAsync(x=>!x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<JobPostingDto>>(jobPostings);
            return map;
        }
    }
}
