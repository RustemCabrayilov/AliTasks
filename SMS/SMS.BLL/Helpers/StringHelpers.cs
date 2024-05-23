using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Helpers
{
	public static class StringHelpers
	{
		public static bool NameFormat(this string name)
		{
			string message = null;
			if(name == null || name.Length < 3)
			{
				message = "Minimum length is 3";
				message.WriteLineError();
				return false;
            }

			if (!char.IsUpper(name[0]))
			{
				message = "First letter must be upper";
				message.WriteLineError();
				return false;
			}

			return true;

		}
		public static void WriteLineError(this string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.White;
        }
		public static void WriteLineSuccess(this string message)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
