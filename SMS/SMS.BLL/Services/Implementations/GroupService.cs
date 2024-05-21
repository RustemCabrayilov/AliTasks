using SMS.App.Models;
using SMS.App.Repositories.Implementations;
using SMS.App.Repositories.Interfaces;
using SMS.App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Services.Implementations
{
	public class GroupService :IGroupService
	{
		private readonly IGroupRepository _groupRepository;
		public GroupService()
		{
			_groupRepository = new GroupRepository();
		}
		public void Add()
		{
			Console.Write("Enter Group Name:");
			string name = Console.ReadLine();

			Group group = new Group()
			{
				Name = name,
				CreatedAt = DateTime.Now,
			};
			_groupRepository.Add(group);
			_groupRepository.Save();
		}

		public void Get()
		{
			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int id);
			Group group = _groupRepository.GetById(id);
			if (group == null)
			{
				Console.WriteLine("Group not found");
				return;
			}
			Console.WriteLine(group);
		}

		public void GetAll()
		{
			List<Group> groups = _groupRepository.GetAll();
			foreach (Group group in groups)
			{
				Console.WriteLine(group);
			}
		}

		public void Remove()
		{
			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int id);
			_groupRepository.Delete(id);
			_groupRepository.Save();
		}

		public void Update()
		{
			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int id);

			Group group = _groupRepository.GetById(id);
			if (group == null)
			{
				Console.WriteLine("Group not found");
				return;
			}
			Console.WriteLine("Old Informations:" + group);

			Console.Write("Enter New Group Name:");
			string name = Console.ReadLine();

			group.Name = name;
			group.UpdatedAt = DateTime.Now;

			_groupRepository.Update(group);
			_groupRepository.Save();

		}
	}
}
