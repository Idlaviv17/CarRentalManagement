using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using System;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IRepository.IUnitOfWork
    {
        private readonly Data.IUnitOfWork _context;
        private IGenericRepository<Make> _makes;

        public UnitOfWork(Data.IUnitOfWork context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
