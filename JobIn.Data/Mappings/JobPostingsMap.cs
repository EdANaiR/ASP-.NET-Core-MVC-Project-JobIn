using JobIn.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
                     Title = "Siber Güvenlik Atolyesi",
                     JobDescription = "C#, .NetCore, Mvc tercihen React...",
                     JobType = "Yüzyüze",
                     JobLocation = "Çanakkale",
                     CategoryId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),

                     ImageId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                     CreatedBy = "Btk Akademi",
                     CreatedDate = "24-05-2024",
                     IsDeleted = false,
                     Deadline = "16-04-2024",
                     JobDeadline = "24 Mayıs",
                     UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                     Advert = "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024",
                     Imagge = "/JobIn-Post/img/ilan/ilan3.png",
                 },

                   new JobPosting
                   {
                       Id = Guid.NewGuid(),
                       Title = "Yarı zamanlı/ stajyer",
                       JobDescription = "Kullanıcı arayüzü tasarımı ve angular kullanarak.....",
                       JobType = "Yüz yüze",
                       JobLocation = "Ankara",
                       CategoryId = Guid.Parse("{6A010829-35BA-4C29-ACE0-BCEA7718672F}"),

                       ImageId = Guid.Parse("{6A010829-35BA-4C29-ACE0-BCEA7718672F}"),
                       CreatedBy = "Cumhurbaşkanlığı Finans Ofisi",
                       CreatedDate = "19-04-2024",
                       IsDeleted = false,
                       Deadline = "02-04-2024",
                       JobDeadline = "19 Nisan",
                       UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
                       Advert = "Geleceğini Şekillendir",
                       Imagge = "/JobIn-Post/img/ilan/ilan1.png",


                   },

                new JobPosting
            {
                Id = Guid.NewGuid(),
                Title = "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024",
                JobDescription = "C#, .NetCore, Mvc tercihen React...",
                JobType = "Yüzyüze",
                JobLocation = "İstanbul",
                CategoryId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),

                ImageId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                CreatedBy = "Farplas",
                CreatedDate = "13-05-2024",
                IsDeleted = false,
                Deadline = "13-06-2024",
                JobDeadline = "23 Haziran",
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                Advert = "Fark’lı ailemizde yer almak istiyorsan hemen başvur!",
                Imagge = "/JobIn-Post/img/ilan/ilan4.png",
            },

            new JobPosting
            {
                Id = Guid.NewGuid(),
                Title = "Teknoloji Transfer Ofisi-Stajyer İlanı",
                JobDescription = "C#, .NetCore, Mvc tercihen React...",
                JobType = "Yüzyüze",
                JobLocation = "İstanbul",
                CategoryId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                
                ImageId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                CreatedBy = "İstanbul Medipol Üniversitesi",
                CreatedDate = "",
                IsDeleted = false,
                Deadline = "",
                JobDeadline = "",
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                Advert= "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı",
                Imagge = "/JobIn-Post/img/ilan/ilan2.png"
            },

            
              new JobPosting
              {
                  Id = Guid.NewGuid(),
                  Title = "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024",
                  JobDescription = "C#, .NetCore, Mvc tercihen React...",
                  JobType = "Yüzyüze",
                  JobLocation = "İstanbul",
                  CategoryId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),

                  ImageId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                  CreatedBy = "Farplas",
                  CreatedDate = "13-06-2024",
                  IsDeleted = false,
                  Deadline = "13-05-2024",
                  JobDeadline = "23 Haziran",
                  UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                  Advert = "Fark’lı ailemizde yer almak istiyorsan hemen başvur!",
                  Imagge = "/JobIn-Post/img/ilan/ilan4.png",
              },


              
               new JobPosting
               {
                   Id = Guid.NewGuid(),
                   Title = "SKY Global Türk Programı",
                   JobDescription = "C#, .NetCore, Mvc tercihen React...",
                   JobType = "Yüzyüze",
                   JobLocation = "İstanbul",
                   CategoryId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),

                   ImageId = Guid.Parse("{B4224B04-73B7-4077-AF1E-81E16A37DE65}"),
                   CreatedBy = "Türk Havacılık ve Uzay Sanayii",
                   CreatedDate = "",
                   IsDeleted = false,
                   Deadline = "",
                   JobDeadline = "",
                   UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                   Advert = "Sky Experience",
                   Imagge = "/JobIn-Post/img/ilan/ilan5.jpg",
               }

                

              




            );
        }


    }
}
