
using SMS.BLL.Services.Implementations;
using SMS.BLL.Services.Interfaces;

namespace SMS.App
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			IMenuService menu = new MenuService();
			await menu.ShowMenuAsync();
		}
	}
}
