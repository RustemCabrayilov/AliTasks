
using SMS.App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SMS.App.Repositories.Interfaces;
using SMS.App.Repositories.Implementations;
using SMS.App.Models;
using SMS.BLL.Helpers;

namespace SMS.App.Services.Implementations
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _studentRepository;
		private readonly IGroupRepository _groupRepository;
		private string message = null;
		public StudentService()
		{
			_studentRepository = new StudentRepository();
			_groupRepository = new GroupRepository();
		}
		public async Task AddAsync()
		{
			Console.Write("Enter Student Name:");
			string name = Console.ReadLine();

			Console.Write("Surname:");
			string surname = Console.ReadLine();

			if (!name.NameFormat() || !surname.NameFormat())
			{
				return;
			}

			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int groupId);

			if (await _groupRepository.GetByIdAsync(groupId) == null)
			{
				Console.WriteLine("Group Not found");
				return;
			}

			await _studentRepository.AddAsync(new Student()
			{
				Name = name,
				Surname = surname,
				GroupId = groupId,
				CreatedAt = DateTime.Now,
			});
			await _studentRepository.SaveAsync();
			message = "Student successfully added!";
			message.WriteLineSuccess();

		}

		public async Task GetAsync()
		{
			Console.Write("Enter Student Id:");
			int.TryParse(Console.ReadLine(), out int id);

			Student student = await _studentRepository.GetByIdAsync(id,"Group");
			if (student != null)
			{
				Console.WriteLine(student);
			}

		}

		public async Task GetAllAsync()
		{
			List<Student> stundets = await _studentRepository.GetAllAsync("Group");

			foreach (Student student in stundets)
			{
				Console.WriteLine(student);
			}
		}

		public async Task RemoveAsync()
		{
			Console.Write("Enter Student Id:");
			int.TryParse(Console.ReadLine(), out int id);

			await _studentRepository.DeleteAsync(id);
			await _studentRepository.SaveAsync();
		}

		public async Task UpdateAsync()
		{
			Console.Write("Enter Student Id:");
			int.TryParse(Console.ReadLine(), out int id);
			Student student = await _studentRepository.GetByIdAsync(id, "Group");

			if (student != null)
			{
				Console.WriteLine("Old Datas:" + student);
				Console.Write("Enter Student Name:");
				string name = Console.ReadLine();

				Console.Write("Surame:");
				string surname = Console.ReadLine();

				if (!name.NameFormat() || !surname.NameFormat())
				{
					return;
				}

				Console.Write("Enter Group Id:");
				int.TryParse(Console.ReadLine(), out int groupId);


				if (await _groupRepository.GetByIdAsync(groupId) == null)
				{
					Console.WriteLine("Group Not found");
					return;
				}
				student.Name = name;
				student.Surname = surname;
				student.GroupId = groupId;
				student.UpdatedAt = DateTime.Now;

				_studentRepository.Update(student);
				await _studentRepository.SaveAsync();
			}
		}
	}
}
