using JobIn.Entity.DTOs.JobPostings;
using JobIn.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Service.Services.Abstractions
{
    public interface IJobPostingService
    {
        Task<List<JobPostingDto>> GetAllJobPostingsWithCayegoryNonDeleteAsync();

        Task CreateJobPostingAsync(JobPostingAddDto jobPostingAddDto);
    }
}
