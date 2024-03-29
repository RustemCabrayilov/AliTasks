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
		public int Id { get; set; }
		public string Name { get; set; }
		public int EmployeeLimit { get; set; }
		private double SalaryLimit = 250;
		public List<Employee> Employees = new List<Employee>();
        public Department(string Name,int EmployeeLimit)
        {
            this.Name = Name;
			this.EmployeeLimit = EmployeeLimit;
			Message("Ugurlu Department yarandi", true);
		}
        public Department()
        {
        }
        public void AddEmployee()
		{
			if(this.Employees.Count >= this.EmployeeLimit)
			{
				Message("Isci limitine catdiniz", false);
				return;
            }


            Console.Write("Id:");
			int Id = int.Parse(Console.ReadLine());
			if (!CheckId(Id))
			{
				Message("Sistemde bu Id-de isci var", false);
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
				Message("Maas 250 den cox olmalidir\nAgain:", false);
				salary = Convert.ToDouble(Console.ReadLine());	
            }
			Employee employee = new Employee();
			employee.Id = Id;
			employee.Name = name;
			employee.Surname = surname;
			employee.Salary = salary;
			employee.Department = this;
			Message("Elave olundu", true);
            Employees.Add(employee);
		}
		public void UpdateEmployee()
		{
            Console.Write("Deyislik etmek istediyiniz iscinin id-sini daxil edin: ");
			int id = int.Parse(Console.ReadLine());
			Employee employee = FindEmployee(id);
			if(employee == null)
			{
				Message("Sistemde bele id-li isci yoxdur", false);
				return;
			}
			Console.WriteLine(employee.ToString());
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
				Message("Maas 250 den cox olmalidir\nAgain:", false);
				salary = Convert.ToDouble(Console.ReadLine());
			}
			employee.Name = name;
			employee.Surname = surname;
			employee.Salary = salary;
			Message("Deyisiklik ugurla yerine yetirildi", true);
		}
		public void ShowEmployees()
		{
			foreach (var employee in Employees)
			{
                Console.WriteLine(employee.ToString());
            }
		}
		public void ShowEmployeeById()
		{
            Console.Write("Axtarmaq istediyiniz iscinin id-sini yazin: ");
			int id = int.Parse(Console.ReadLine());
			Employee employee = FindEmployee(id);
			if(employee == null)
			{
				Message("Sistemde bele id-li isci yoxdur", false);
				return;
			}
            Console.WriteLine(employee.ToString());
		}
		public void RemoveById()
		{
            Console.Write("Silmek istediyiniz iscinin id-sini daxil edin: ");
			int id = int.Parse(Console.ReadLine());
			Employee employee = FindEmployee(id);
			if (employee == null)
			{
				Message("Sistemde bele id-li isci yoxdur", false);
				return;
			}
			Employees.Remove(employee);
			Message("Ugurlu emeliyyat", true);
		}
		private bool CheckName(string data)
		{
			if (data.Length == 0)
			{
				return false;
			}
			if (!char.IsUpper(data[0]))
			{
				Message("Ad ve ya soyad boyuk herf ile baslamalidir!!!", false);
                return false;
			}
			
			for (int i = 0; i < data.Length; i++)
			{
				if (!char.IsLetter(data[i]))
				{
					Message("Ad ve ya soyad yalniz herfler ibaret olmalidir!!!", false);
					return false;
				}
			}
			return true;
		}
		private bool CheckId(int id)
		{
			foreach(var employee in Employees)
			{
				if (employee.Id == id)
				{
					return false;
				}
			}
			return true;
		}
		private Employee FindEmployee(int id)
		{
			foreach (var employee in Employees)
			{
				if(employee.Id == id)
				{
					return employee;
				}
			}
			return null;
		}
		private void Message(string message,bool isSuccess)
		{
			if (isSuccess)
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
			}
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
