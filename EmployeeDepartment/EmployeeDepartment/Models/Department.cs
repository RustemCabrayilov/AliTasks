using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeDepartment.Models
{
	public class Department
	{
		public string Name { get; set; }
		public int EmployeeLimit { get; set; }
		private double SalaryLimit = 250;
		public List<Employee> Employees = new List<Employee>();
        public Department(string Name,int EmployeeLimit)
        {
            this.Name = Name;
			this.EmployeeLimit = EmployeeLimit;
        }
        public Department()
        {
        }
        public void AddEmployee()
		{
			if(Employees.Count >= EmployeeLimit)
			{
                Console.WriteLine("Isci limitine catdiniz");
				return;
            }
			Console.Write("Employee Name: ");
			string name = Console.ReadLine();
			Console.Write("Surname: ");
			string surname = Console.ReadLine();

			while (!CheckName(surname) || !CheckName(name))
			{
				Console.Write("Employee Name: ");
				name = Console.ReadLine();
				Console.Write("Surname: ");
			    surname = Console.ReadLine();
			
			}
			Console.Write("Salary: ");
			double salary = Convert.ToDouble(Console.ReadLine());
			while (salary < SalaryLimit)
			{
                Console.WriteLine("Maas 250 den cox olmalidir");
				Console.Write("Again: ");
				salary = Convert.ToDouble(Console.ReadLine());	
            }
			Employee employee = new Employee();
			employee.Name = name;
			employee.Surname = surname;
			employee.Salary = salary;
			employee.Department = this;
            Console.WriteLine("Elave olundu");
            Employees.Add(employee);
		}
		public void ShowEmployees()
		{
			foreach (var employee in Employees)
			{
                Console.WriteLine("Name: "+employee.Name + " Surname: " +employee.Surname + " Salary: "+ employee.Salary + " Department: "+employee.Department.Name);
            }
		}
		public void RemoveByName()
		{
			Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Silmek istediyiniz adi daxil edin: ");
			string name = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;

			foreach (var employee in Employees)
			{
				if(employee.Name.ToLower().Trim() == name.ToLower().Trim())
				{
					Employees.Remove(employee);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
					Console.ForegroundColor = ConsoleColor.White;
					return;
				}
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Bele isci sistemde yoxdur");
			Console.ForegroundColor = ConsoleColor.White;
		}
		private bool CheckName(string data)
		{
			if (data.Length == 0)
			{
				return false;
			}
			if (!char.IsUpper(data[0]))
			{
                Console.WriteLine("Ad ve ya soyad boyuk herf ile baslamalidir!!!");
                return false;
			}
			
			for (int i = 0; i < data.Length; i++)
			{
				if (!char.IsLetter(data[i]))
				{
					Console.WriteLine("Ad ve ya soyad yalniz herfler ibaret olmalidir!!!");
					return false;
				}
			}
			return true;
		}

	}
}
