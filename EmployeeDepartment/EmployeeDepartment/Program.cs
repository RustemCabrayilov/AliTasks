using EmployeeDepartment.Extensions;
using EmployeeDepartment.Models;

namespace EmployeeDepartment
{
	internal class Program
	{
		public static List<Department> departmentList = new List<Department>();
		static void Main(string[] args)
		{
            bool isContinue = true;
			string msg = string.Empty;
			string Menu1 = "1.Department Create\n" +
					"2.Department Show\n" +
					"3.Department Show By ID\n" +
					"4.Department Update\n" +
					"5.Department Remove\n" +
					"6.Change Employee Department\n"+
					"7.Main Menu";

			string Menu2 = "1.Employee Create\n" +
					"2.Employee Show\n" +
					"3.Employee Show By Id\n" +
					"4.Employee Update\n" +
					"5.Employee Remove\n" +
					"6.Main Menu";
			string Menu = "1.Department Menu\n" +
				"2.Employee Menu\n" +
				"3.Exit";
			while (isContinue)
			{
				Console.WriteLine(Menu);
				Console.Write("Operationun nomresini daxil edin:");
				int operation = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				bool isContinue1 = true;
				switch (operation)
				{
					case 1:
						
						while(isContinue1)
						{
							Console.WriteLine(Menu1);
							Console.Write("Operationun nomresini daxil edin:");
						    operation = Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							switch (operation)
							{
								case 1:
									CreateDepartment();
									break;
								case 2:
									ShowDepartments();
									break;
								case 3:
									ShowDepartmentsById();
									break;
								case 4:
									UpdateDepartment();
									break;
								case 5:
									RemoveDepartment();
									break;
								case 6:
									ChangeEmployeeDepartment();
									break;
								case 7:
									isContinue1 = false;
									break;
								default:
									msg = "Operation nomresi yanlisdir";
									msg.Message(ConsoleColor.Red);
									break;
							}
						}
						break;
					case 2:
						Console.Write("Islem goreceyiniz departmentin id-sini daxil edin: ");
						int id = Convert.ToInt32(Console.ReadLine());
						Department department = FindDepartment(id);
						while (isContinue1)
						{
							if(department == null)
							{
								msg = "Bu id-de Department yoxdur";
								msg.Message(ConsoleColor.Red);
								break;
                            }
                            Console.WriteLine(Menu2);
							Console.Write("Operationun nomresini daxil edin:");
							operation = Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							switch (operation)
							{
								case 1:
									department.AddEmployee();
									break;
								case 2:
									department.ShowEmployees();
									break;
								case 3:
									department.ShowEmployeeById();
									break;
								case 4:
									department.UpdateEmployee();
									break;
								case 5:
									department.RemoveById();
									break;
								case 6:
									isContinue1 = false;
									break;
								default:
									msg = "Operation nomresi yanlisdir";
									msg.Message(ConsoleColor.Red);
									break;
                            }
						}
						break;
					case 3:
						Console.WriteLine("Cixis olunur....");
						isContinue = false;
						break;
					default:
						msg = "Operation nomresi yanlisdir";
						msg.Message(ConsoleColor.Red);
						break;
				}

			}
		}

		private static Department FindDepartment(int id)
		{
			foreach (var department in departmentList)
			{
				if (department.Id == id)
				{
					return department;
				}
			}
			return null;
		}
		private static void CreateDepartment()
		{
			string msg = string.Empty;
            Console.Write("Department Name:");
			string name = Console.ReadLine();

			Console.Write("Employee Limit:");
			int limit =int.Parse( Console.ReadLine());

			Department department = new Department(name, limit);
			departmentList.Add(department);
			msg = "Department ugurla yarandi";
			msg.Message(ConsoleColor.Green);
        }
		private static void ShowDepartments()
		{
			if (departmentList.Count == 0)
			{
				string msg = "Ilk once department elave edin";
				msg.Message(ConsoleColor.Red);
				return ;
			}

           foreach(var department in departmentList)
			{
                Console.WriteLine(department.ToString());
            }
        }
		private static void ShowDepartmentsById()
		{
			string msg = string.Empty;
			if (departmentList.Count == 0)
			{
				msg = "Ilk once department elave edin";
				msg.Message(ConsoleColor.Red);
				return;
			}
			Console.Write("Id:");
			int id = int.Parse(Console.ReadLine());
			Department department = FindDepartment(id);
			if (department != null)
			{
				Console.WriteLine(department.ToString());
			}
			else
			{
				msg = "Bu Id-de Department yoxdur";
				msg.Message(ConsoleColor.Red);
			}
            Console.WriteLine(department.ToString());

        }
		private static void RemoveDepartment()
		{
			string msg = string.Empty;
			Console.Write("Silmek istediyiniz Department-in id-sini daxil edin: ");
			int id = int.Parse(Console.ReadLine());
			Department department = FindDepartment(id);
			if (department == null)
			{
				msg = "Sistemde bu id-de Department yoxdur";
				msg.Message(ConsoleColor.Red);
				return;
			}
			departmentList.Remove(department);
			msg = "Ugurlu emeliyyat";
			msg.Message(ConsoleColor.Green);
		}
		private static void UpdateDepartment()
		{
			string msg = string.Empty;
			Console.Write("Deyislik etmek istediyiniz departmentin id-sini daxil edin: ");
			int id = int.Parse(Console.ReadLine());
			Department department = FindDepartment(id);
			if (department == null)
			{
				msg = "Sistemde bu id-de department yoxdur";
				msg.Message(ConsoleColor.Red);
				return;
			}
			Console.WriteLine(department.ToString());


			Console.Write("Deparment Name: ");
			string name = Console.ReadLine();

			Console.Write("Employee Limit: ");
			int employeeLimit = int.Parse(Console.ReadLine());

		
			department.Name = name;
			department.EmployeeLimit = employeeLimit;
			msg = "Deyisiklik ugurla yerine yetirildi";
			msg.Message(ConsoleColor.Green);
		}
		private static void ChangeEmployeeDepartment()
		{
			string msg = string.Empty;

			Console.Write("Id:");
			int id = int.Parse(Console.ReadLine());

			Employee employee = FindEmployee(id);

			if(employee  == null)
			{
				msg = "Sistemde bu id-de employee yoxdur";
				msg.Message(ConsoleColor.Red);
				return;
			}

            Console.WriteLine(employee.ToString());

			Department department = null;
			do
			{
				Console.Write("Deyismek istediyiniz Departmentin id-sini daxil edin: ");
				int departmentId = int.Parse(Console.ReadLine());
			     department = FindDepartment(departmentId);
				if(department != null)
				{
					employee.Department.Employees.Remove(employee);
					department.Employees.Add(employee);
					break;
				}
				Console.Clear();
                Console.WriteLine("Bu id-de Department tapilmadi!!!");
            }
			while (true);
            Console.WriteLine(department.ToString());
            employee.Department = department;

			msg = "Ugurlu Yerdeyisme";
			msg.Message(ConsoleColor.Green);


		}
		private static Employee FindEmployee(int id)
		{
			foreach (var department in departmentList)
			{
				foreach (var employee in department.Employees)
				{
					if (id == employee.Id)
					{
						return employee;
					}
				}
			}
			return null;
		}
	}
}
