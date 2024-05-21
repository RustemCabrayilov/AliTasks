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
        public T Add(T entity)
		{
			_dbSet.Add(entity);
			return entity;
		}

		public void Delete(int id)
		{
			var entity =GetById(id);
			if(entity != null)
				_dbSet.Remove(entity);
		}

		public List<T> GetAll()
		  => _dbSet.ToList();

		public T GetById(int id)
			=> _dbSet.FirstOrDefault(d => d.Id == id);

		public void Save()
		 => _context.SaveChanges();

		public void Update(T entity)
		   => _dbSet.Update(entity);
	}
}
