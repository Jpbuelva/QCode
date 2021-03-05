using Infraestructure.Core.Context;
using Infraestructure.Core.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ContextSql _context;
        protected readonly DbSet<T> _entities;

        public Repository(ContextSql context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return await _entities.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
        }

        public void Update(T entity)
        {

            _entities.Update(entity);

        }


    }
}
