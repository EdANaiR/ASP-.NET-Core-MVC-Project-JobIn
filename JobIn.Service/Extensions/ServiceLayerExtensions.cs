using JobIn.Data.Context;
using JobIn.Data.Repositories.Abstractions;
using JobIn.Data.Repositories.Concretes;
using JobIn.Data.UnitOfWorks;
using JobIn.Entity.Entities;
using JobIn.Service.Services.Abstractions;
using JobIn.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IJobPostingService, JobPostingService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(assembly);  
            return services;
        }
    }
}
