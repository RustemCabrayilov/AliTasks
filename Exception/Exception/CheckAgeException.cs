using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	public class CheckAgeException : Exception
	{
		public CheckAgeException()
		{
		}

		public CheckAgeException(string? message) : base(message)
		{
		}
	}
}
