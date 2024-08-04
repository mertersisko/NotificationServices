using NotificationServices.Application.Repositories;
using NotificationServices.Persistence.NotificationServicesContextes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NotificationServicesContext context;
        public UnitOfWork(NotificationServicesContext _context)
        {
            context = _context;
        }
        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}
