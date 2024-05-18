using JobIn.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Data.Mappings
{
    public class JobPostingsMap : IEntityTypeConfiguration<JobPosting>
    {

        public void Configure(EntityTypeBuilder<JobPosting> builder)
        {
            builder.HasData(new JobPosting
            {
                Id = Guid.NewGuid(),
                Title = "Asels Part-Time iş ilanı",
                JobDescription = "Kullanıcı arayüzü tasarımı ve angular kullanarak.....",
                JobType = "Remote",
                JobLocation = "Ankara",
                CategoryId = Guid.Parse("{6A010829-35BA-4C29-ACE0-BCEA7718672F}"),
                
                ImageId = Guid.Parse("{6A010829-35BA-4C29-ACE0-BCEA7718672F}"),
                CreatedBy = "Aselsa",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Deadline = "2024 Mart",
                UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
            },

            new JobPosting
            {
                Id = Guid.NewGuid(),
                Title = "Sabancı Full-Stack Developer",
                JobDescription = "C#, .NetCore, Mvc tercihen React...",
                JobType = "Hibrit",
                JobLocation = "Ankara",
                CategoryId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                
                ImageId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                CreatedBy = "Sabancı",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Deadline = "2024 Mart",
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            }
            );
        }


    }
}
