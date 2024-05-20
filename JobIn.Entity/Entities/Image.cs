using JobIn.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Entity.Entities 
{
    public class Image : EntityBase,IEntityBase 
    {
        
        public string? FileName { get; set; }
        public string? FileType { get; set; }

        public ICollection<JobPosting> Postings { get; set;}
        public ICollection<AppUser> Users { get; set;}   
    }
}
