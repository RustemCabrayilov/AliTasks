using SMS.App.Services.Implementations;
using SMS.App.Services.Interfaces;
using SMS.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Services.Implementations
{
	public class MenuService : IMenuService
	{
		public async Task ShowMenuAsync()
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
				Console.Clear();
				switch (operationNumber)
				{
					case 1:
						IService groupService = new GroupService();
						await SubMenuAsync(groupService);
						break;
					case 2:
						IService studentService = new StudentService();
						await SubMenuAsync(studentService);
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

		private async Task SubMenuAsync(IService service)
		{
			bool isContinue = true;
			string type = service.GetType().ToString().Split(".")[4].Split("Service")[0];


			Console.WriteLine($"{type} Menu");

			do
			{
				Console.WriteLine($"1.Add {type} \n" +
					$"2.Update {type}\n" +
					$"3.Remove {type}\n" +
					$"4.Get {type}\n" +
					$"5.Get All {type}s\n" +
					"0.Exit Menu");

				Console.Write("Enter operation Number:");

				int.TryParse(Console.ReadLine(), out var operationNumber);
				Console.Clear();

				switch (operationNumber)
				{
					case 1:
						await service.AddAsync();
						break;
					case 2:
						await service.UpdateAsync();
						break;
					case 3:
						await service.RemoveAsync();
						break;
					case 4:
						await service.GetAsync();
						break;
					case 5:
						await service.GetAllAsync();
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
