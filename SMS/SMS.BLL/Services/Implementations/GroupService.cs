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
		public async Task AddAsync()
		{
			Console.Write("Enter Group Name:");
			string name = Console.ReadLine();

			Group group = new Group()
			{
				Name = name,
				CreatedAt = DateTime.Now,
			};
			await _groupRepository.AddAsync(group);
			await _groupRepository.SaveAsync();
		}

		public async Task GetAsync()
		{
			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int id);
			Group group = await _groupRepository.GetByIdAsync(id);
			if (group == null)
			{
				Console.WriteLine("Group not found");
				return;
			}
			Console.WriteLine(group);
		}

		public async Task GetAllAsync()
		{
			List<Group> groups = await _groupRepository.GetAllAsync();
			foreach (Group group in groups)
			{
				Console.WriteLine(group);
			}
		}

		public async Task RemoveAsync()
		{
			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int id);
			await _groupRepository.DeleteAsync(id);
			await _groupRepository.SaveAsync();
		}

		public async Task UpdateAsync()
		{
			Console.Write("Enter Group Id:");
			int.TryParse(Console.ReadLine(), out int id);

			Group group = await _groupRepository.GetByIdAsync(id);
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
			await _groupRepository.SaveAsync();

		}
	}
}
