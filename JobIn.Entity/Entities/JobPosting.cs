using JobIn.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Entity.Entities
{
    public class JobPosting : EntityBase, IEntityBase
    {
        
        public string Title { get; set; }
        public string? JobDescription { get; set; }
        public string? JobLocation { get; set; } 
        public string? JobType { get; set; } 

        public string? CreatedBy { get; set; } 

        public DateTime CreatedDate { get; set; } = DateTime.Now;


        public Guid? CategoryId { get; set; }
        public Category? Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image? Image { get; set; }    

                               

        public string? Deadline { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
