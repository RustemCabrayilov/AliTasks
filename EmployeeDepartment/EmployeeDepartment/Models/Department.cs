using EmployeeDepartment.Extensions;
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
        public Department(int id,string Name,int EmployeeLimit)
        {
			this.Id = id;
            this.Name = Name;
			this.EmployeeLimit = EmployeeLimit;
		}
        public Department()
        {
        }

		public override string ToString()
		{
			return "Id: " + this.Id + "  Name: " + this.Name + " Employee Count: " + this.Employees.Count + "  Employee Limit: " + this.EmployeeLimit;
		}
		public void AddEmployee()
		{
			string msg = string.Empty;
			if(this.Employees.Count >= this.EmployeeLimit)
			{
			    msg = "Isci limitine catdiniz";
				msg.Message(ConsoleColor.Red);
				
				return;
            }


            Console.Write("Id:");
			int Id = int.Parse(Console.ReadLine());
			if (!CheckId(Id))
			{
			  msg = "Sistemde bu Id-de isci var";
				msg.Message(ConsoleColor.Red);
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
			    msg = "Maas 250 den cox olmalidir\nAgain:";
				msg.Message(ConsoleColor.Red);
				salary = Convert.ToDouble(Console.ReadLine());	
            }
			Employee employee = new Employee();
			employee.Id = Id;
			employee.Name = name;
			employee.Surname = surname;
			employee.Salary = salary;
			employee.Department = this;
            Employees.Add(employee);
			msg = "Ugurla Elave olundu";
			msg.Message(ConsoleColor.Green);
		}
		public void UpdateEmployee()
		{
			string msg = string.Empty;
            Console.Write("Deyislik etmek istediyiniz iscinin id-sini daxil edin: ");
			int id = int.Parse(Console.ReadLine());
			Employee employee = FindEmployee(id);
			if(employee == null)
			{
				msg = "Sistemde bele id-li isci yoxdur";
				msg.Message(ConsoleColor.Red);
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
				msg = "Maas 250 den cox olmalidir\nAgain:";
				msg.Message(ConsoleColor.Red);
				salary = Convert.ToDouble(Console.ReadLine());
			}
			employee.Name = name;
			employee.Surname = surname;
			employee.Salary = salary;
			msg = "Deyisiklik ugurla yerine yetirildi";
			msg.Message(ConsoleColor.Green);
		}
		public void ShowEmployees()
		{
			if(Employees.Count == 0)
			{
				string msg = "Ilk once isci elave edin";
				msg.Message(ConsoleColor.Red);
				return;
			}
			foreach (var employee in Employees)
			{
                Console.WriteLine(employee.ToString());
            }
		}
		public void ShowEmployeeById()
		{
			string msg = string.Empty;
            Console.Write("Axtarmaq istediyiniz iscinin id-sini yazin: ");
			int id = int.Parse(Console.ReadLine());
			Employee employee = FindEmployee(id);
			if(employee == null)
			{
				msg = "Sistemde bele id-li isci yoxdur";
				msg.Message(ConsoleColor.Red);
				return;
			}
            Console.WriteLine(employee.ToString());
		}
		public void RemoveById()
		{
			string msg = string.Empty;
            Console.Write("Silmek istediyiniz iscinin id-sini daxil edin: ");
			int id = int.Parse(Console.ReadLine());
			Employee employee = FindEmployee(id);
			if (employee == null)
			{
				msg = "Sistemde bele id-li isci yoxdur";
				msg.Message(ConsoleColor.Red);
				return;
			}
			Employees.Remove(employee);
			msg = "Ugurlu emeliyyat";
			msg.Message(ConsoleColor.Green);
		}
		private bool CheckName(string data)
		{
			string msg = string.Empty;
			if (data.Length == 0)
			{
				return false;
			}
			if (!char.IsUpper(data[0]))
			{
				msg = "Ad ve ya soyad boyuk herf ile baslamalidir!!!";
				msg.Message(ConsoleColor.Red);
                return false;
			}
			
			for (int i = 0; i < data.Length; i++)
			{
				if (!char.IsLetter(data[i]))
				{
					msg = "Ad ve ya soyad yalniz herfler ibaret olmalidir!!!";
					msg.Message(ConsoleColor.Red);
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
	}
}
