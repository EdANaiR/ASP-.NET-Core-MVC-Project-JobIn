using JobIn.Core.Entities;
using JobIn.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Data.Mappings
{
    public class CategoryMap :IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("{6A010829-35BA-4C29-ACE0-BCEA7718672F}"),
                Name = "İş İlanı",
               
                

            },

            new Category
            {
                Id = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                Name = "Staj İlanı",
                
                
            });

           
        }


    }
}
