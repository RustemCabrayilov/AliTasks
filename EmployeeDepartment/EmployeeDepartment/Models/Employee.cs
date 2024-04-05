using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment.Models
{
	public class Employee
	{
		public readonly int Id;
		public string Name { get; set; }
		public string Surname { get; set; }
		public double Salary { get; set; }
		public Department Department { get; set; }
		private static int _count;

		public Employee()
		{
			_count++;
			Id = _count;
		}

		public override string ToString()
		{
			return "Id: " + this.Id + " Name: " + this.Name + " Surname: " + this.Surname + " Salary: " + this.Salary + " Department: " + this.Department.Name;
		}
	}
}
