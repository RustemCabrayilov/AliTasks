using Generics.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DataStores
{
	public class DataStore<T> /*where T :*/ /*class*/ /*struct*/ /*new()*/ /*Person*/ /*ICollection<T>*/ /*IEnumerable*/
	{
		public T data { get; set; }
		public List<T> Datas = new List<T>();

		public void GetType()
		{
			Type type = typeof(T);
            Console.WriteLine(type.ToString());
        }
	}
}
