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
    [Migration("20240517223637_Init3")]
    partial class Init3
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
                            ConcurrencyStamp = "9ca16d86-0d89-48f1-bafe-f8b7f1fad558",
                            Name = "SuperAdmin",
                            NormalizedName = "SuperAdmin"
                        },
                        new
                        {
                            Id = new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                            ConcurrencyStamp = "316c0c4d-b63d-4923-8385-042e8a1faa9b",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                            ConcurrencyStamp = "98ce0070-e631-4ff1-aa92-6c920e6da514",
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
                            ConcurrencyStamp = "e7294e5b-de7c-48af-90f5-6dbe8b23e56d",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Hakan",
                            ImageId = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            LastName = "Keskin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENvDBA4gbcZ7K3HZp/DE9qQWr7ebnlO/Lel9Pj9a4+c/iyjxrY6K431LXtk/4nQmLw==",
                            PhoneNumber = "+905439999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "dac92f66-6799-43da-8bea-306dc705e909",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a7c5374-855c-42e5-ab7b-821e6bc7ca6c",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEH6pOsF7k3Oeot7PbQ8cNeAQoaeDrAx3I6UWffMlKK+3CRe8FjGOXzh+J/kD4KPkBA==",
                            PhoneNumber = "+905439999988",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0bbb8c79-c59d-4f19-8830-c75e3c1c43bd",
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

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            CreatedBy = "Undefined",
                            IsDeleted = false,
                            Name = "İş İlanı"
                        },
                        new
                        {
                            Id = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Undefined",
                            IsDeleted = false,
                            Name = "Staj İlanı"
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            CreatedBy = "Undefined",
                            FileName = "images/testimage",
                            FileType = "jpg"
                        },
                        new
                        {
                            Id = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Undefined",
                            FileName = "images/testimage",
                            FileType = "jpg"
                        });
                });

            modelBuilder.Entity("JobIn.Entity.Entities.JobPosting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Deadline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .IsRequired()
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
                            Id = new Guid("83db07fa-e448-4190-b9fc-a1bb2dd43ec5"),
                            CategoryId = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            CreatedBy = "Aselsa",
                            CreatedDate = new DateTime(2024, 5, 18, 1, 36, 35, 922, DateTimeKind.Local).AddTicks(487),
                            Deadline = "2024 Mart",
                            ImageId = new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                            IsDeleted = false,
                            JobDescription = "Kullanıcı arayüzü tasarımı ve angular kullanarak.....",
                            JobLocation = "Ankara",
                            JobType = "Remote",
                            Title = "Asels Part-Time iş ilanı",
                            UserId = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c")
                        },
                        new
                        {
                            Id = new Guid("bd14ef68-d950-4ede-a9fc-982874cd57a7"),
                            CategoryId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            CreatedBy = "Sabancı",
                            CreatedDate = new DateTime(2024, 5, 18, 1, 36, 35, 922, DateTimeKind.Local).AddTicks(495),
                            Deadline = "2024 Mart",
                            ImageId = new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                            IsDeleted = false,
                            JobDescription = "C#, .NetCore, Mvc tercihen React...",
                            JobLocation = "Ankara",
                            JobType = "Hibrit",
                            Title = "Sabancı Full-Stack Developer",
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