#region HomeTasks
#region Task2
//int[] num = { 19, 94, 87, 43 };
//int maxNumber = num[0];
//for (int i = 1; i < num.Length; i++)
//{
//	if (num[i] > maxNumber)
//	{
//		maxNumber = num[i];
//	}
//}
//Console.WriteLine("Max number:" + maxNumber);
#endregion
#region Task3
//int[] ededler = { 4, 5, 8, 2, -5, 0, 2 };
//int cem = 0;

//for (int i = 0; i < ededler.Length; i++)
//{
//	cem = cem + ededler[i];
//}

//Console.WriteLine("Ededlerin cemi:"+cem);
//Console.WriteLine($"Ededlerin cemi:{cem}");
#endregion
#region Task4
//*
//* *
//* * *
//* * * *
//* * * * *
//setirin sayi ve hansi setirde oldugumuzu
//for (int i = 1; i <= 5; i++)
//{
//	for (int j = 1; j <= i; j++)
//	{
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}

//* * * * *
//* * * *
//* * *
//* *
//*
//for (int i = 1; i <= 5; i++)
//{
//	for (int j = 6-i; j >= 1; j--)
//	{
//		Console.Write("* ");
//	}
//	Console.WriteLine();
//}

//   *
//  * *
// * * *
//* * * *
// * * *
//  * *
//   *
#endregion
#endregion
#region Tekrar
//int i = 0;
//while (i <= 5)
//{
//	Console.WriteLine(i);
//	i++;
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

//int[] ededler = { 3, 5, -3, 26, 2, -7 };

//for (int i = 0; i < ededler.Length; i++)
//{
//	if(i == 3)
//	{
//		continue;
//	}
//	Console.WriteLine(ededler[i]);
//}

//for (int i = 0; i < ededler.Length; i++)
//{
//    Console.Write(ededler[i]+" ");
//}
//Array.Sort(ededler);
//Console.WriteLine("\nSortdan sonrasi....");
//for (int i = 0; i < ededler.Length; i++)
//{
//	Console.Write(ededler[i] + " ");
//}
//Array.Reverse(ededler);
//Console.WriteLine("\nReverden sonrasi....");
//for (int i = 0; i < ededler.Length; i++)
//{
//	Console.Write(ededler[i] + " ");
//}

//Console.WriteLine("\n-3 un indexi:"+Array.IndexOf(ededler,-3));
//Console.WriteLine("\n-4 un indexi:" + Array.IndexOf(ededler, -4));

#endregion
#region Foreach
//int[] ededler = { 3, 5, -3, 26, 2, -7 };
//string[] adlar = { "Ali", "Nijat", "Nihad" };
//for (int i = 0; i < ededler.Length; i++)
//{
//    Console.WriteLine(ededler[i]);
//}
//foreach (int eded in ededler)
//{
//    Console.WriteLine(eded);
//}
//foreach (string ad in adlar)
//{
//    Console.WriteLine(ad);
//}
#endregion
#region ArrayList Lists
using System.Collections;
#region ArrayList
//int[] ededler = { 3, 5, -3, 26, 2, -7 };
//Tipin onceden vermeliyik ve bir tipden datalar qebul edir
//Olcusu evvelceden teyin olunur ve deyismir
//Add ve Remove etmek olmur
//string[] adlar = { "Ali", "Nijat", "Nihad" };
#region Intro
//ArrayList datalar = new ArrayList();

//datalar.Add(3);
//datalar.Add("Ali");
//datalar.Add(-3);
//datalar.Add(new
//{
//	Ad = "Ali",
//	Soyad = "Agayev"
//});

//foreach (var data in datalar)
//{
//	Console.WriteLine(data);
//}
#endregion
#region Methods
//ArrayList ededler = new ArrayList();
//Add
//ededler.Add(3);
//ededler.Add(-5);
//ededler.Add(5);
//ededler.Add(-6);
//ededler.Add(10);


//Insert(Index,qoymaq istediyin eded)
//ededler.Insert(3, 7);


//RemoveAt(Silmek istedyimiz ededin indexi)
//ededler.RemoveAt(5);

//Sort
//Console.WriteLine("Sortdan evvelki");
//foreach (var eded in ededler)
//{
//	Console.WriteLine(eded);
//}
//Console.WriteLine("****************************");
//Console.WriteLine("Sortdan sonra");
//ededler.Sort();
//foreach (var eded in ededler)
//{
//	Console.WriteLine(eded);
//}

//Reverse
//Console.WriteLine("Reversden evvelki");
//foreach (var eded in ededler)
//{
//	Console.WriteLine(eded);
//}
//Console.WriteLine("****************************");
//Console.WriteLine("Reversden sonra");
//ededler.Reverse();
//foreach (var eded in ededler)
//{
//	Console.WriteLine(eded);
//}

//foreach (var eded in ededler)
//{
//	Console.WriteLine(eded);
//}

//AddRange
//ededler.Add(1);
//ededler.Add(2);
//ededler.Add(3);

//int[] ededler2 = { 1, 2, 3};
//ededler.AddRange(ededler2);
//Console.WriteLine("********************");
//foreach (var eded in ededler)
//{
//	Console.WriteLine(eded);
//}
#endregion
#endregion
#region List
//List<int> ints = new List<int>();
#endregion
#endregion
#region AccessModifier
//public -> Her kes terefinden 
//private -> Aid oldugu class daxilinde
//internal -> Verilen namespace daxilinde
//protected -> Aid oldugu class daxilinde ve miras verdiyimiz classlarda 
#endregion