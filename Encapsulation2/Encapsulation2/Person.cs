using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
	public class Person
	{
		private string _name;
		private int _age;

		public string GetName()
		{
			return _name;
		}

		public void SetName(string value)
		{
			_name = value;
		}
		public int GetAge()
		{
			return _age;
		}
		public void SetAge(int value)
		{
			_age = value;
		}
	}
}
