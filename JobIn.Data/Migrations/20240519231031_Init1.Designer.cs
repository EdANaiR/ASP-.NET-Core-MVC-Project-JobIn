﻿// <auto-generated />
using System;
using JobIn.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobIn.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240519231031_Init1")]
    partial class Init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobIn.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                            ConcurrencyStamp = "d8da2b19-5cae-4447-b872-2954dc0dc47a",
                            Name = "SuperAdmin",
                            NormalizedName = "SuperAdmin"
                        },
                        new
                        {
                            Id = new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                            ConcurrencyStamp = "ef8e0492-937c-41f0-a625-25a3c10a10a7",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                            ConcurrencyStamp = "5f5cc538-14d9-46a6-b37c-5b28436c8bad",
                            Name = "User",
                            NormalizedName = "User"
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "70026802-1975-4fe8-8685-c760197f0282",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Hakan",
                            ImageId = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            LastName = "Keskin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEE/kgf5oYS+Eleczg64dfqePRFbk704YaqTsUT9ocBChRA5lPgBK/YjaFAm+5tjiPQ==",
                            PhoneNumber = "+905439999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "13b849a5-101c-45a3-ae83-a9a7312b02c5",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dfabcce6-3b99-4f71-a70c-227067b03e25",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENIXip1jqEO7NfJcJvd0oIG0CGgNdo+P3KVFFaEm67kGpCe49kUkA2Tz4ek22sOLJg==",
                            PhoneNumber = "+905439999988",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72ccd0ef-7c27-4d71-861f-fba187619fce",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            RoleId = new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252")
                        },
                        new
                        {
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            RoleId = new Guid("348a28d8-f597-4e02-8304-cd0308af29b2")
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("JobIn.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            IsDeleted = false,
                            Name = "İş İlanı"
                        },
                        new
                        {
                            Id = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            IsDeleted = false,
                            Name = "Staj İlanı"
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.JobPosting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Advert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deadline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Imagge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JobDeadline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("JobPostings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("920c3d6b-79da-49c9-bdda-5c7bc4290965"),
                            Advert = "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024",
                            CategoryId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Btk Akademi",
                            CreatedDate = "24-05-2024",
                            Deadline = "16-04-2024",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            Imagge = "/JobIn-Post/img/ilan/ilan3.png",
                            IsDeleted = false,
                            JobDeadline = "24-05-2024",
                            JobDescription = "C#, .NetCore, Mvc tercihen React...",
                            JobLocation = "Çanakkale",
                            JobType = "Yüzyüze",
                            Title = "Siber Güvenlik Atolyesi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427")
                        },
                        new
                        {
                            Id = new Guid("62c05954-2df6-43d2-acf7-a19ff64fbb61"),
                            Advert = "Geleceğini Şekillendir",
                            CategoryId = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            CreatedBy = "Cumhurbaşkanlığı Finans Ofisi",
                            CreatedDate = "19-04-2024",
                            Deadline = "02-04-2024",
                            ImageId = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            Imagge = "/JobIn-Post/img/ilan/ilan1.png",
                            IsDeleted = false,
                            JobDeadline = "19-04-2024",
                            JobDescription = "Kullanıcı arayüzü tasarımı ve angular kullanarak.....",
                            JobLocation = "Ankara",
                            JobType = "Yüz yüze",
                            Title = "Yarı zamanlı/ stajyer",
                            UserId = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c")
                        },
                        new
                        {
                            Id = new Guid("3974a6a1-c7f7-464e-a5e2-ad2f400142a6"),
                            Advert = "Fark’lı ailemizde yer almak istiyorsan hemen başvur!",
                            CategoryId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Farplas",
                            CreatedDate = "13-05-2024",
                            Deadline = "13-06-2024",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            Imagge = "/JobIn-Post/img/ilan/ilan4.png",
                            IsDeleted = false,
                            JobDeadline = "23 Haziran",
                            JobDescription = "C#, .NetCore, Mvc tercihen React...",
                            JobLocation = "İstanbul",
                            JobType = "Yüzyüze",
                            Title = "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427")
                        },
                        new
                        {
                            Id = new Guid("fc7241af-e206-4b40-95a5-768a30239b0d"),
                            Advert = "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı",
                            CategoryId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "İstanbul Medipol Üniversitesi",
                            CreatedDate = "",
                            Deadline = "",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            Imagge = "/JobIn-Post/img/ilan/ilan2.png",
                            IsDeleted = false,
                            JobDeadline = "",
                            JobDescription = "C#, .NetCore, Mvc tercihen React...",
                            JobLocation = "İstanbul",
                            JobType = "Yüzyüze",
                            Title = "Teknoloji Transfer Ofisi-Stajyer İlanı",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427")
                        },
                        new
                        {
                            Id = new Guid("5ed6ab53-c2e1-4214-ace6-b057dfccf647"),
                            Advert = "Fark’lı ailemizde yer almak istiyorsan hemen başvur!",
                            CategoryId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Farplas",
                            CreatedDate = "",
                            Deadline = "",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            Imagge = "/JobIn-Post/img/ilan/ilan4.png",
                            IsDeleted = false,
                            JobDeadline = "",
                            JobDescription = "C#, .NetCore, Mvc tercihen React...",
                            JobLocation = "İstanbul",
                            JobType = "Yüzyüze",
                            Title = "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427")
                        },
                        new
                        {
                            Id = new Guid("078d3b69-abe3-458a-b654-5a1efc72924e"),
                            Advert = "Sky Experience",
                            CategoryId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Türk Havacılık ve Uzay Sanayii",
                            CreatedDate = "",
                            Deadline = "",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            Imagge = "/JobIn-Post/img/ilan/ilan5.jpg",
                            IsDeleted = false,
                            JobDeadline = "",
                            JobDescription = "C#, .NetCore, Mvc tercihen React...",
                            JobLocation = "İstanbul",
                            JobType = "Yüzyüze",
                            Title = "SKY Global Türk Programı",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427")
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobIn.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobIn.Entity.Entities.JobPosting", b =>
                {
                    b.HasOne("JobIn.Entity.Entities.Category", "Category")
                        .WithMany("Postings")
                        .HasForeignKey("CategoryId");

                    b.HasOne("JobIn.Entity.Entities.Image", "Image")
                        .WithMany("Postings")
                        .HasForeignKey("ImageId");

                    b.HasOne("JobIn.Entity.Entities.AppUser", "User")
                        .WithMany("Postings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobIn.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Postings");
                });

            modelBuilder.Entity("JobIn.Entity.Entities.Category", b =>
                {
                    b.Navigation("Postings");
                });

            modelBuilder.Entity("JobIn.Entity.Entities.Image", b =>
                {
                    b.Navigation("Postings");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}