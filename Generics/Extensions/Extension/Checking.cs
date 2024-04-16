using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Extension
{
	public static class Checking
	{
		public static bool ControlPassword(this string password)
		{
			bool[] answers = { false, false, false, false };
			int count = 0;
			//int countN = 0;
			if (password.Length < 8)
				return false;

			//Nijat123@

			foreach (char c in password)
			{
				if (char.IsDigit(c) && !answers[0])
				{
					answers[0] = true;
				}
				if(char.IsLower(c) && !answers[1])
				{
					answers[1] = true;
				}
				if (char.IsUpper(c) && !answers[2])
				{
					answers[2] = true;
				}
				if (!char.IsLetterOrDigit(c) && !answers[3])
				{
					answers[3] = true;
				}
			}

			foreach(var answer in answers)
			{
				if (answer)
				{
					count++;
				}
			}

			//countN = answers.Where(x=>x).Count();
			if(count == answers.Length)
			{
				return true;
			}
			return false;
		}
	}
}
