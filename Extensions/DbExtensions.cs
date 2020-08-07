using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PO.Infrastructure.Core.UnitOfWork;

namespace PO.Infrastructure.Core.Extensions
{
    public static class DbExtensions
    {
        public static void AddUnitOfWork<TDbContext>(this IServiceCollection services)
            where  TDbContext : DbContext
        {
            var i = typeof(IUnitOfWorkBase).GetDerivedTypes(true).Single();
            var c = typeof(UnitOfWorkBase<TDbContext>).GetDerivedTypes().Single();
            // add unit of work 
            services.Add(new ServiceDescriptor(i, c, ServiceLifetime.Scoped));
        }
    }
}