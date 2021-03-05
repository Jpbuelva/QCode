using Infraestructure.Core.Context;
using Infraestructure.Core.Repository;
using Infraestructure.Core.Repository.Interface;
using Infraestructure.Core.UnitOfWork.Interface;
using Infraestructure.Entity.Entity;
using System.Threading.Tasks;

namespace Infraestructure.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextSql _context;
        private readonly IRepository<ImagenEntity> _imagenRepository;

        public UnitOfWork(ContextSql context)
        {
            _context = context;
        }

        public IRepository<ImagenEntity> ImagenRepository => _imagenRepository ?? new Repository<ImagenEntity>(_context);
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
