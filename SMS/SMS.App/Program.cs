using SMS.App.Services.Implementations;
using SMS.App.Services.Interfaces;

namespace SMS.App
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool isContinue = true;
			Console.WriteLine("Welcome to Student Management System");
			do
			{
				Console.WriteLine("1.Group Menu \n" +
					"2.Student Menu\n" +
					"0.Exit Program");

				Console.Write("Enter operation Number:");

				int.TryParse(Console.ReadLine(), out var operationNumber);

				switch (operationNumber)
				{
					case 1:
						GroupMenu();
						break;
					case 2:
						StudentMenu();
						break;
					case 0:
						isContinue = false;
						break;
					default:
						Console.WriteLine("Enter valid operation Number");
						break;
				}
			}
			while (isContinue);
		}

		private static void GroupMenu()
		{
			bool isContinue = true;
			IGroupService service = new GroupService();

			Console.WriteLine("Group Menu");

			do
			{
				Console.WriteLine("1.Add Group \n" +
					"2.Update Group\n" +
					"3.Remove Group\n" +
					"4.Get Group\n" +
					"5.Get All Groups\n" +
					"0.Exit Menu");

				Console.Write("Enter operation Number:");

				int.TryParse(Console.ReadLine(), out var operationNumber);

				switch (operationNumber)
				{
					case 1:
						service.Add();
						break;
					case 2:
						service.Update();
						break;
					case 3:
						service.Remove();
						break;
					case 4:
						service.Get();
						break;
					case 5:
						service.GetAll();
						break;
					case 0:
						isContinue = false;
						break;
					default:
						Console.WriteLine("Enter valid operation Number");
						break;
				}
			}
			while (isContinue);
		}
		private static void StudentMenu()
		{
			bool isContinue = true;
			IStudentService service = new StudentService();

			Console.WriteLine("Student Menu");

			do
			{
				Console.WriteLine("1.Add Student \n" +
					"2.Update Student\n" +
					"3.Remove Student\n" +
					"4.Get Student\n" +
					"5.Get All Students\n" +
					"0.Exit Menu");

				Console.Write("Enter operation Number:");

				int.TryParse(Console.ReadLine(), out var operationNumber);

				switch (operationNumber)
				{
					case 1:
						service.Add();
						break;
					case 2:
						service.Update();
						break;
					case 3:
						service.Remove();
						break;
					case 4:
						service.Get();
						break;
					case 5:
						service.GetAll();
						break;
					case 0:
						isContinue = false;
						break;
					default:
						Console.WriteLine("Enter valid operation Number");
						break;
				}
			}
			while (isContinue);
		}
	}
	}
