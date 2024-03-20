namespace StringMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			//int tipindən array və
			//1 int tipindən ədəd qəbul edən metod yazın.
			//Metod bu ədədin bu arrayin hər hansı bir elementinə bərabər olub-olmadığını tapsın.
			//int[] numbers = { 1, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
			//         Console.Write("Hansi ededi axtarmaq istiyirsiniz:");
			//int number = int.Parse(Console.ReadLine());
			//         bool result = FindNumber(numbers,number);
			//         Console.WriteLine(result);
			#endregion
			#region Task2
			//Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
			//Console.Write("Eded daxil edin:");
			//int number = int.Parse(Console.ReadLine());

			//int result = Factorial(number);

			//         Console.WriteLine("Factorial:"+result);
			#endregion
			#region StringMethods
			//string name = "Ali";
			//string surname = "Agayev";

			//Length property
			//Console.WriteLine(surname.Length);

			//ToLower ToUpper
			//Console.WriteLine(name.ToUpper());
			//Console.WriteLine(name.ToLower());

			//Concat
			//string fullName = name + " " + surname;
			//string fullName = String.Concat(name," ", surname);
			//         Console.WriteLine(fullName);

			//Compare
			//Eger beraberdise 0 qaytarir, yox eger beraber deyilse 1;
			//int result = String.Compare(name, surname);
			//int result2 = String.Compare(name, "Ali");
			//if(result == 0)
			//{
			//             Console.WriteLine("Textler eynidir");
			//         }
			//else if(result2 == 0)
			//{
			//             Console.WriteLine("Textler beraber deyil");
			//         }
			// Console.WriteLine(result);
			//  Console.WriteLine(result2);


			//IsNullOrEmpty
			//string nullDeyer = null;

			//Console.WriteLine(String.IsNullOrEmpty(name));  //False
			//Console.WriteLine(String.IsNullOrEmpty(nullDeyer));  //True

			//IsNullOrWhiteSpace

			//string bosluq = " ";
			//Console.WriteLine(String.IsNullOrEmpty(bosluq)); //False
			// Console.WriteLine(String.IsNullOrWhiteSpace(bosluq)); //True

			//Contain
			//Console.WriteLine(name.Contains('a'));

			//StartWith  EndWith

			//Console.WriteLine(name.ToLower().StartsWith("a"));
			//Console.WriteLine(surname.ToUpper().EndsWith("V"));


			//Trim Sagdan Soldanda bosluqlari silir

			//string text = " Ali Agayev ";

			//         Console.WriteLine(text.Trim());

			//Insert

			//string text1 = "Salam necesen?";

			//string newText=text1.Insert(6,name+" ");
			//         Console.WriteLine(newText);

			//IndexOf

			//Console.WriteLine(name.ToLower().IndexOf("a"));
			//string text = "Salam qardas";

			//Console.WriteLine(text.IndexOf("a",2));
			//Remove
			//string text = "Salam qardas";
			//string newtxt = text.Remove(text.IndexOf('q'));
			//Console.WriteLine(newtxt);


			//Replace
			//string text = "Salam qardas";
			//string newtxt = text.Replace('a', 'e');
			//Console.WriteLine(newtxt);

			//Split
			//string text = "Nicat,Ali,Nihad,Mammad,Ahmad";
			//string[] names = text.Split(',');
			//foreach (var item in names)
			//{
			//    Console.WriteLine(item);
			//}
			//Substring

			//string text = "Salam qardas";

			//string newtxt = text.Substring(6);
			//Console.WriteLine(newtxt);

			//Console.WriteLine(newtxt.ToLower().Equals("Qardas".ToLower()));
			//string fullName = String.Join(" ",name,surname);
			//Console.WriteLine(fullName);

			//char[] herfler = name.ToLower().ToCharArray();

			//foreach (var item in herfler)
			//{
			// Console.WriteLine(item);
			//}

			#endregion
			#region MathMethods
			//Abs Modulun tapir
			//int number = -5;
			//int newNumber =Math.Abs(number);
			//         Console.WriteLine(newNumber);

			//Sqrt Kokalti
			//Console.WriteLine(Math.Sqrt(25));


			//Pow
			//Console.WriteLine(Math.Pow(5,3));
			//Console.WriteLine(Math.Pow(125, (double)1 / 3));

			//Max Min
			//Console.WriteLine(Math.Max(14,15));

			//Console.WriteLine(Math.Min(14, 15));

			//Round Bizim bildiyimiz duzgun yuvarlaqlasdirma
			//Console.WriteLine(Math.Round(13.1784,3));

			//Ceiling Yuxariya yuvarlaqdirir

			//Console.WriteLine(Math.Ceiling(13.2));

			//Floor En asagiya yuvarlaqdirir
			//Console.WriteLine(Math.Floor(13.2));

			//Sin
			//Console.WriteLine(Math.SinCos(0));
			//double angle = Math.PI * -30 / 180.0;
			//Console.WriteLine(Math.Sin(angle));

			int sayi1 = 37;

			int sayi2 = 28;
			//Hasil
			long sonuc = Math.BigMul(sayi1,sayi2);
			
			Console.WriteLine(sonuc);

			#endregion

		}
		public static bool FindNumber(int[] numbers, int findNumber)
		{
			foreach (int number in numbers)
			{
				if (number == findNumber)
				{
					return true;
				}
			}
			return false;
		}
		public static int Factorial(int number)
		{
			int hasil = 1;
			for (int i = 1; i <= number; i++)
			{
				hasil = hasil * i;
			}
			return hasil;
		}
	}
}
