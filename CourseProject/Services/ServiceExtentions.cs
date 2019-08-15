using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.Extensions.Configuration;
using CourseProject.Services;

namespace CourseProject
{
    public static class ServiceExtentions
    {
        public static IServiceCollection RegisterTourServices(this IServiceCollection services, IConfiguration Configuration)
        {
            return services.AddScoped<ITourCollection>(_ => new TourCollection(Configuration["MongoStr"]));
        }

        public static IServiceCollection RegisterExcursionServices(this IServiceCollection services, IConfiguration Configuration)
        {
            return services.AddScoped<IExcursionCollection>(_ => new ExcursionCollection(Configuration["MongoStr"]));
        }

        public static IServiceCollection RegisterAgencyServices(this IServiceCollection services, IConfiguration Configuration)
        {
            return services.AddScoped<IAgencyCollection>(_ => new AgencyCollection(Configuration["MongoStr"]));
        }

        public static IServiceCollection RegisterUserServices(this IServiceCollection services, IConfiguration Configuration)
        {
            return services.AddScoped<IUserCollection>(_ => new UserCollection(Configuration["MongoStr"]));
        }
    }
}
