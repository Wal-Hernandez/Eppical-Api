using System;
using System.Collections.Generic;
using System.Text;
using EppicalApi.Data.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace EppicalApi.Data.Extensions
{
    namespace EppicalApi.Infrastructure.Extensions
    {
        public static class ServiceExtensions
        {
            public static void ConfigureInMemoryDatabase(this IServiceCollection services)
            {
                services.AddDbContext<DataContext>(options =>
                    options.UseInMemoryDatabase("EppicalApi"));
                services.AddAutoMapper(typeof(ServiceExtensions));

            }
        }
    }
}
    