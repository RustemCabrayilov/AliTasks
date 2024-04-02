using EmployeeDepartment.Models;

namespace EmployeeDepartment
{
	internal class Program
	{
		public static List<Department> departmentList = new List<Department>();
		static void Main(string[] args)
		{
            bool isContinue = true;
			string Menu1 = "1.Department Create\n" +
					"2.Department Show\n" +
					"3.Department Show By ID\n" +
					"4.Department Update\n" +
					"5.Department Remove\n" +
					"6.Main Menu";

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
									ShowDepartmentsById();
									break;
								case 5:
									ShowDepartmentsById();
									break;
								case 6:
									isContinue1 = false;
									break;
								default:
									Message("Operation nomresi yanlisdir", false);
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
                                Console.WriteLine("Bu id-de Department yoxdur");
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
									Message("Operation nomresi yanlisdir", false);
									break;
                            }
						}
						break;
					case 3:
						Console.WriteLine("Cixis olunur....");
						isContinue = false;
						break;
					default:
						Message("Operation nomresi yanlisdir", false);
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

			Console.Write("Id:");
			int id = int.Parse(Console.ReadLine());
			if (!CheckId(id))
			{
				Message("Sistemde bu Id-de department var", false);
				return;
			}
            Console.Write("Department Name:");
			string name = Console.ReadLine();

			Console.Write("Employee Limit:");
			int limit =int.Parse( Console.ReadLine());

			Department department = new Department(id, name, limit);
			departmentList.Add(department);
			Message("Department yarandi", true);
        }
		private static void ShowDepartments()
		{
			if (departmentList.Count == 0)
			{
				Message("Ilk once department elave edin", false);
				return ;
			}

           foreach(var department in departmentList)
			{
                Console.WriteLine(department.ToString());
            }
        }
		private static void ShowDepartmentsById()
		{
			if (departmentList.Count == 0)
			{
				Message("Ilk once department elave edin", false);
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
				Message("Bu Id-de Department yoxdur",false);
			}
		
		}

		private static bool CheckId(int id)
		{
			foreach (var department in departmentList)
			{
				if (department.Id == id)
				{
					return false;
				}
			}
			return true;
		}

		private static void Message(string message, bool isSuccess)
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
/*
 * Console.Write("Department Name: ");
						string name = Console.ReadLine();
						Console.Write("Employee Limit(int): ");
						int employeeLimit = Convert.ToInt32(Console.ReadLine());
						department = new Department(name,employeeLimit);
						break;
 * 
 * 
 */

/*	if (department.Name == null)
						{
							Console.WriteLine("Ilk once department yaradin");
							break;
						}
*/