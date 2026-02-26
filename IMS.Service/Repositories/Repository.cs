using IMS.Infrastructure.Data;
using IMS.Service.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Service.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context = new();
        public Repository() { }
        public async Task AddAsync(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
           await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                return _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Entity with id {id} not found.");
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null)
        {
            var entity = await _context.Set<T>().ToListAsync();
            if (!string.IsNullOrEmpty(includeProperties))
            {
                var properties = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var property in properties)
                {
                    entity = await _context.Set<T>().Include(property.Trim()).ToListAsync();
                }
            }

            return entity;

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id).AsTask();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
