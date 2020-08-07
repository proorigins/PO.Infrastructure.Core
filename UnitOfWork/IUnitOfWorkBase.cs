using System;
using System.Threading.Tasks;

namespace PO.Infrastructure.Core.UnitOfWork
{
    public interface IUnitOfWorkBase : IDisposable
    {
        Task SaveAsync();
    }
}