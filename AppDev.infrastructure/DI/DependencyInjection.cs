﻿using AppDev.Application.Common.Interface;
using AppDev.Infrastructure.Persistance;
using AppDev.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppDev.Infrastructure.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString(name: "AppDevDatabasePostgreSQL"),
            b => 
            b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)),
            ServiceLifetime.Transient);

            services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ApplicationDBContext>());
            services.AddTransient<IDateTime, DateTimeService>();

            return services;
        }
    }
}
