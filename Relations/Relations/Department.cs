using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
	public class Department
	{
		//- EmployeeLimit
		//- SalaryLimit 
		//- Employees
		public string Name { get; set; }
		public int EmployeeLimit { get; set; }
		public double SalaryLimit { get; set; }
		public List<Employee> Employees { get; set; }

        public Department(string Name,int EmployeeLimit,double SalaryLimit)
        {
			this.Name = Name;
			this.EmployeeLimit = EmployeeLimit;
			this.SalaryLimit = SalaryLimit;
        }
    }
}
