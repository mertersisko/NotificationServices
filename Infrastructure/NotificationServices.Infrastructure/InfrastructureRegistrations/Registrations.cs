using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NotificationServices.Application.Repositories;
using NotificationServices.Application.Services;
using NotificationServices.Infrastructure.Repositories;
using NotificationServices.Infrastructure.Services;
using NotificationServices.Persistence.NotificationServicesContextes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Infrastructure.InfrastructureRegistrations
{
    public static class Registrations
    {
        public static void AddNotificationServicesDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NotificationServicesContext>(options => options.UseSqlServer(connectionString));
        }
        public static void AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUnitService, UnitService>();
        }
    }
}
