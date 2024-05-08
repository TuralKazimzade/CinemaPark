using DAL.Abstract;
using DAL.Concrete.EfCore.Contexts;
using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore.Repositories
{
   public  class GenericRepository<T> : IGeneric<T> where T : class, ITable, new()
    {
        private AppDbContext _appDbContext;
        
        public DbSet<T> Table { get; set; }
        public GenericRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
            Table = _appDbContext.Set<T>(); 
        }
        public async Task<bool> AddAsync(T entity)
        {
           var result = await Table.AddAsync(entity);
            return result.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
        {
            Table.AddRange(entities);
            return true;
        }

        public async Task<bool> Contains(T entity)
        {
            return await Table.ContainsAsync(entity);
        }

        public   async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public bool Remove(T entity)
        {
            var result = Table.Remove(entity);
            return result.State == EntityState.Deleted;
        }

        public bool RemoveRange(IEnumerable<T> entity)
        {
            Table.RemoveRange(entity);
            return true;
        }

        public bool Update(T entity)
        {
            var result = Table.Update(entity);
            return result.State == EntityState.Modified;
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
