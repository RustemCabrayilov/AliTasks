using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Services.Interfaces
{
	public interface IService
	{
		public Task AddAsync();
		public Task UpdateAsync();
		public Task RemoveAsync();
		public Task GetAsync();
		public Task GetAllAsync();
	}
}
