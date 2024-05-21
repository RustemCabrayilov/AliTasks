
using SMS.App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SMS.App.Repositories.Interfaces;
using SMS.App.Repositories.Implementations;
using SMS.App.Models;

namespace SMS.App.Services.Implementations
{
	public class StudentService :IStudentService
	{
		private readonly IStudentRepository _studentRepository;
		private readonly IGroupRepository _groupRepository;

		public StudentService()
		{
			_studentRepository = new StudentRepository();
			_groupRepository = new GroupRepository();
		}
		public void Add()
		{
			Console.Write("Enter Student Name:");
			string name = Console.ReadLine();

			Console.Write("Surame:");
			string surname = Console.ReadLine();

			Console.WriteLine("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int groupId);


			if (_groupRepository.GetById(groupId) == null)
			{
				Console.WriteLine("Group Not found");
				return;
			}

			_studentRepository.Add(new Student()
			{
				Name = name,
				Surname = surname,
				GroupId = groupId,
				CreatedAt = DateTime.Now,
			});
			_studentRepository.Save();
		}

		public void Get()
		{
			Console.Write("Enter Student Id:");
			int.TryParse(Console.ReadLine(), out int id);

			Student student = _studentRepository.GetById(id);
			if (student != null)
			{
				Console.WriteLine(student);
			}

		}

		public void GetAll()
		{
			List<Student> stundets = _studentRepository.GetAll();

			foreach (Student student in stundets)
			{
				Console.WriteLine(student);
			}
		}

		public void Remove()
		{
			Console.Write("Enter Student Id:");
			int.TryParse(Console.ReadLine(), out int id);
			if (_studentRepository.GetById(id) != null)
			{
				_studentRepository.Delete(id);
				_studentRepository.Save();
			}
		}

		public void Update()
		{
			Console.Write("Enter Student Id:");
			int.TryParse(Console.ReadLine(), out int id);
			Student student = _studentRepository.GetById(id);

			if (student != null)
			{
				Console.Write("Enter Student Name:");
				string name = Console.ReadLine();

				Console.Write("Surame:");
				string surname = Console.ReadLine();

				Console.WriteLine("Enter Group Id:");
				int.TryParse(Console.ReadLine(), out int groupId);


				if (_groupRepository.GetById(groupId) == null)
				{
					Console.WriteLine("Group Not found");
					return;
				}
				student.Name = name;
				student.Surname = surname;
				student.GroupId = groupId;
				student.UpdatedAt = DateTime.Now;

				_studentRepository.Update(student);
				_studentRepository.Save();
			}
		}
	}
}
