using JobIn.Entity.DTOs.Categories;
using JobIn.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Entity.DTOs.JobPostings
{
    public class JobPostingAddDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public CategoryDto Category { get; set; }

        public Guid CategoryId { get; set; }
       
        public string? CreatedBy { get; set; }  
        public string? JobType { get; set; }
        public Image? Image { get; set; }

        public List<CategoryDto> Categories { get; set; }
    }
}
