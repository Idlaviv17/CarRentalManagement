using CarRentalManagement.Shared.Domain;
using System;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
        IGenericRepository<Make> Makes { get; }
    }
}
