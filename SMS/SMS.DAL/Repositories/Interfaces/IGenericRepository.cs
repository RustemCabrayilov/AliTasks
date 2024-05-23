using SMS.App.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Repositories.Interfaces
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		public Task<T> AddAsync(T entity);
		public void Update(T entity);
		public Task DeleteAsync(int id);
		public Task<List<T>> GetAllAsync(params string[] includes);
		public Task<T> GetByIdAsync(int id,params string[] includes);
		public void Save();
		public Task SaveAsync();
	}
}
