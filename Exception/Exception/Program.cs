using Exceptions.Models;

namespace Exceptions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region NullReferenceException
			//string name = null;
			//try
			//{
			//             Console.WriteLine(name);
			//         }
			//catch (NullReferenceException ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}

			//Console.WriteLine("salam eli");

			#endregion

			#region IndexOutOfException

			//List<string> names = new List<string>();

			//names.Add("Ali");
			//names.Add("Nijat");
			//try
			//{
			//	Console.WriteLine(names[2]);
			//}
			//catch(Exception  ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			//finally
			//{
			//             Console.WriteLine("Try catch bloku sonlandi");
			//         }

			#endregion

			#region Throw



			//         try
			//         {
			//	Console.WriteLine("Yasinizi daxil edin");
			//	int age = int.Parse(Console.ReadLine());

			//	if (age < 18)
			//	{
			//                 throw new CheckAgeException("Yasiniz 18 den kicikdir");
			//	}
			//}
			//         catch(NullReferenceException ex) 
			//         {
			//             Console.WriteLine(ex.Message);
			//         }
			//         catch (ArithmeticException ex)
			//         {
			//             Console.WriteLine(ex.Message);
			//         }
			//         catch(CheckAgeException ex)
			//         {
			//             Console.WriteLine(ex.Message);
			//         }



			#endregion


			//Employee mc = new Employee();
			//try
			//{
			//	mc.Method();
			//}
			//catch (Exception ex)
			//{
			//             Console.WriteLine(ex.Message);
			//             Console.WriteLine("Exception caught here");
			//}
			//Console.WriteLine("LAST STATEMENT");

			//Console.WriteLine("deyisken daxil edin:");
   //         bool.TryParse(Console.ReadLine(), out bool result);
   //         Console.WriteLine(result);
        }

		class Employee
		{
			public void Method()
			{
				try
				{
					int x = 0;
					int sum = 100 / x;
				}
				catch (DivideByZeroException ex)
				{
					throw ex;
                    Console.WriteLine("Exception tapildi");
                }
			}
		}
	}
}
