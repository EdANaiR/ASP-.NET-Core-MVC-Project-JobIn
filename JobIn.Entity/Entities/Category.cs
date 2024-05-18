using JobIn.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Entity.Entities
{
    public class Category : EntityBase, IEntityBase
    {
       
        public string Name { get; set; }

        public ICollection<JobPosting> Postings { get; set; }
        public bool IsDeleted { get; set; }
    }
}
