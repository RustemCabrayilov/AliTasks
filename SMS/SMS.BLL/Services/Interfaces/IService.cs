using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Services.Interfaces
{
	public interface IService
	{
		public void Add();
		public void Update();
		public void Remove();
		public void Get();
		public void GetAll();
	}
}
