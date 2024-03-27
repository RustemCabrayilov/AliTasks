using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
	public class Employee :Person
	{
		public double Salary { get; set; }
		public Department Department { get; set; }

		public Employee(string Name,string Surname,int Age,double Salary,Department Department):base(Name,Surname,Age)
		{
			this.Salary = Salary;
			this.Department = Department;
		}

	}
}
