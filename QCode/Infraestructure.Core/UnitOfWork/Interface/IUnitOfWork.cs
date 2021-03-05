using Infraestructure.Core.Repository.Interface;
using Infraestructure.Entity.Entity;
using System.Threading.Tasks;

namespace Infraestructure.Core.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        IRepository<ImagenEntity> ImagenRepository { get; }

        void Dispose();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}