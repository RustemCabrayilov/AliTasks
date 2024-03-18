namespace MethodOverLoading
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine( Sum(10, 14,15));
			//         Console.WriteLine(Sum((short)1,(short)2));
			//Sum(10, 15);
			//Sum(10.5, 20.4);
			//string fullName = ConcatName("Ali", "Agayev");
			//         Console.WriteLine(fullName);
			//         Console.WriteLine(ConcatName("Nijat","Soltanov"));

			int[] array = { 1, 2, 3, 4 ,8,4};
			//SumArray(array);
			int result = MaxElement(array);
            Console.WriteLine(result);
        }
		#region Sum
		//public static int Sum(int number1, int number2)
		//{
		//	int sum = number1 + number2;
		//	return sum;
		//}
		//public static int Sum(Int16 number1, Int16 number2)
		//{
		//	int sum = number1 + number2;
		//	return sum;
		//}
		//Method Overloading 
		//public static int Sum(int number1, int number2, int number3)
		//{
		//	int sum = number1 + number2 + number3;
		//	return sum;
		//}
		#endregion
		#region OverLoading
		//public static void Sum(int number1,int number2)
		//{
		//          Console.WriteLine(number1+number2);
		//      }
		//public static void Sum(int number1, int number2,int number3)
		//{
		//	Console.WriteLine(number1 + number2+number3);
		//}
		//public static void Sum(double number1,double number2) 
		//{ 
		//	Console.WriteLine(number1+number2);
		//}

		//1.Aldigi parametrlerin type
		//2.Aldigi parametrlerin sayi
		//3.Geri donus type
		#endregion
		public static string ConcatName(string name, string surname)
		{
			string fullName = name + " " + surname;
			return fullName;
		}
		public static void SumArray(int[] arr)
		{
			int sum = 0;
			foreach (int item in arr)
			{
				sum += item;
			}
			Console.WriteLine("Sum of elements:" + sum);
		}

		//Array qəbul edən metod yazın. Metod bu arrayin icinde ən böyüyünü tapıb qaytarsın

		public static int MaxElement(int[] arr) 
		{
			int max = arr[0];
			foreach (var item in arr)
			{
				if (item > max)
				{
					max = item;
				}
			}
			return max;

		}

		
	}
}
