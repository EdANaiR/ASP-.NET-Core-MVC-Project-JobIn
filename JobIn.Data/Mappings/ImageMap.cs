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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {

        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("{6A010829-35BA-4C29-ACE0-BCEA7718672F}"),
                FileName = "images/testimage",
                FileType = "jpg",
                
                
            },


            new Image
            {
                Id = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                FileName = "images/testimage",
                FileType = "jpg",
                
                
            });



        }


    }
}
