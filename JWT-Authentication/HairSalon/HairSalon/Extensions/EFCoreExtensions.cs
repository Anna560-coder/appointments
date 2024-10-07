﻿using HairSalon.Models;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Extensions
{
    public static class EFCoreExtensions
    {
        public static IServiceCollection InjectDbContext(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(config.GetConnectionString("DevDB")));
            return services;
        }
    }
}
