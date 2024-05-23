using Microsoft.EntityFrameworkCore;
using SMS.App.Context;
using SMS.App.Models.BaseModel;
using SMS.App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Repositories.Implementations
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private readonly SMSDbContext _context;
		private readonly DbSet<T> _dbSet;

		public GenericRepository()
		{
			_context = new SMSDbContext();
			_dbSet = _context.Set<T>();
		}
		public async Task<T> AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			return entity;
		}

		public async Task DeleteAsync(int id)
		{
			var entity = await GetByIdAsync(id);
			if (entity != null)
				_dbSet.Remove(entity);
		}

		public async Task<List<T>> GetAllAsync(params string[] includes)
		{
			var query = _dbSet.AsQueryable();
			foreach (var include in includes)
			{
				query = query.Include(include);
			}
			return await query.ToListAsync();
		}
		  

		public async Task<T> GetByIdAsync(int id, params string[] includes)
		{
			var query = _dbSet.Where(x => x.Id == id);
			foreach (var include in includes)
			{
				query = query.Include(include);
			}
			return await query.FirstOrDefaultAsync();
		}

		public void Save()
		 => _context.SaveChanges();
		public async Task SaveAsync()
			=> await _context.SaveChangesAsync();

		public void Update(T entity)
		   => _dbSet.Update(entity);
	}
}
