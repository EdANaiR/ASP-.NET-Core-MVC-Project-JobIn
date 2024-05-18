using JobIn.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {

        public AppDbContext()
        {
            
        }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<JobPosting> JobPostings { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Image> Images { get; set; }    

        

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);     //migration hatası almamak için eklendi
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }








    }
}
