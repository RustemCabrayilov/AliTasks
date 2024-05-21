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
		public T Add(T entity);
		public void Update(T entity);
		public void Delete(int id);
		public List<T> GetAll();
		public T GetById(int id);
		public void Save();
	}
}
