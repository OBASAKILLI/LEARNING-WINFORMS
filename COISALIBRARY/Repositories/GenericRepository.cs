

using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISALIBRARY.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly CoisaDbContext _context;

        public GenericRepository(CoisaDbContext coisaDbContext)
        {
            _context = coisaDbContext;
        }
        public async Task Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public async Task<IEnumerable<T>> GetAll(T entity)
        {
            return await _context.Set<T>().ToListAsync();  
        }

        public async Task<T> GetById(string Id)
        {
            return await _context.Set<T>().FindAsync(Id);
        }

        public async Task Remove(T entity)
        {

            _context.Set<T>().Remove(entity);
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
