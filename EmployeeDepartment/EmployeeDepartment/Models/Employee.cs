using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public double Salary { get; set; }
		public Department Department { get; set; }

		public override string ToString()
		{
			return "Id: " + this.Id + " Name: " + this.Name + " Surname: " + this.Surname + " Salary: " + this.Salary + " Department: " + this.Department.Name;
		}
	}
}
