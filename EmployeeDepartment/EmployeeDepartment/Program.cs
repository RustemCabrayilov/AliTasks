using EmployeeDepartment.Models;

namespace EmployeeDepartment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Department department = new();
			bool isContinue = true;
		 while (isContinue)
			{
                Console.WriteLine("1.Department Yarat\n" +
					"2.Isci elave ele\n" +
					"3.Iscileri goster\n" +
					"4.Iscini ad ile sil\n" +
					"5.Cixis");

                Console.Write("Operationun nomresini daxil edin:");
				int operation = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				switch (operation)
				{
					case 1:
						Console.Write("Department Name: ");
						string name = Console.ReadLine();
						Console.Write("Employee Limit(int): ");
						int employeeLimit = Convert.ToInt32(Console.ReadLine());
						department = new Department(name,employeeLimit);
						break;
					case 2:
						if(department.Name == null)
						{
                            Console.WriteLine("Ilk once department yaradin");
							break;
                        }
						department.AddEmployee();
					break;
					case 3:
						if (department.Employees.Count == 0)
						{
							Console.WriteLine("Ilk once isci elave eliyin");
							break;
						}
						department.ShowEmployees();
					break;
					case 4:
						if (department.Employees.Count == 0)
						{
							Console.WriteLine("Ilk once isci elave eliyin");
							break;
						}
						department.RemoveByName();
						break;
					case 5:
                        Console.WriteLine("Cixis olunur....");
						isContinue = false;
						break;

					default:
                        Console.WriteLine("Duzgun operation nomresini daxil edin");
						break;
                }

            }
		}
	}
}
