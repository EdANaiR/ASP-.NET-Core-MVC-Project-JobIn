using JobIn.Entity.DTOs.Categories;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Entity.DTOs.JobPostings
{
    public class JobPostingDto
    {
        
        public Guid Id {  get; set; } 
        public string Title { get; set; }
        public CategoryDto Category { get; set; }
              
        public DateTime CreatedDate { get; set; }  
        public string? CreatedBy { get; set; } 
        public bool IsDeleted { get; set; }
        public string? JobType { get; set; }  
    }


    
}
