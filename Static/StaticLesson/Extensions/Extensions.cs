using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLesson.Extensions
{
	public static class Extensions
	{
		public static bool IsGreaterThanZero(this int number)
		{
			if(number < 0)
			{
				return false;
			}
			return true;
		}
		public static string ToUpperByAli(this string text)
		{
			return text.ToUpper();
		}
		public static string JoinByAli(this string text,string text2)
		{
             return text + text2;
		}
		public static void Cap(this Array array)
		{
			foreach (var item in array)
			{
                Console.WriteLine(item);
            }
		}
		public static int SumByAli(this int[] array)			
		{
			int sum = 0;
			foreach(var item in array)
			{
				sum = sum + item;
			

            }
			return sum;

		}
		public static List<int> SimpleNumbers(this List<int> list)
		{
			List<int> simples = new List<int>();
			foreach (var number in list)
			{
				if(number <= 1)
				{
					continue;
				}
				int count = 0;
				for (int i = 2; i < number; i++)
				{
					if(number %  i == 0)
					{
						count++;
					}
				}
				if(count == 0)
				{
					simples.Add(number);	
				}
			}
			return simples;
		}

		public static void Message(this string text,bool isError)
		{
			if (isError)
				Console.ForegroundColor = ConsoleColor.Red;
			else
				Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine(text);

			Console.ForegroundColor = ConsoleColor.White;
		}


	}
}
