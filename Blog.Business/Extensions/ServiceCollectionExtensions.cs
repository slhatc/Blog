using Blog.Business.Abstract;
using Blog.Business.Concrete;
using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection services)
        {



            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAboutService, AboutManager>();

 

            return services;
        }
    }
}
