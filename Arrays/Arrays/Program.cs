#region AliTask 

//bool DavatEtsinmi = true;
//while (DavatEtsinmi)
//{

//	Console.WriteLine("Toplama için 1");
//	Console.WriteLine("Çıkarma için 2");
//	Console.WriteLine("Çarpma için 3");
//	Console.WriteLine("Bölme için 4");
//	Console.WriteLine("Sonlandir 5");
//	Console.Write("Yapılacak işlemi seçin:");

//	int islem = int.Parse(Console.ReadLine());

//	Console.Write("birinci sayiyi giriniz:");
//	double sayi1 = double.Parse(Console.ReadLine());

//	Console.Write("ikinci sayiyi giriniz:");
//	double sayi2 = double.Parse(Console.ReadLine());

//	double sonuc = 0;
//	switch (islem)
//	{
//		case 1:
//			sonuc = sayi1 + sayi2;
//			Console.WriteLine("Toplama sonucu: " + sonuc);
//			break;

//		case 2:
//			sonuc = sayi1 - sayi2;
//			Console.WriteLine("cixma sonucu" + sonuc);
//			break;

//		case 3:
//			sonuc = sayi1 * sayi2;
//			Console.WriteLine("vurma sonucu" + sonuc);
//			break;

//		case 4:
//			if (sayi2 != 0)
//			{
//				sonuc = sayi1 / sayi2;
//				Console.WriteLine("Bölme sonucu: " + sonuc);
//			}
//			else
//			{
//				Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
//			}
//			break;
//		case 5:
//			Console.ForegroundColor = ConsoleColor.Red;
//			Console.WriteLine("Program Sonlanir...");
//			Thread.Sleep(2000);
//            DavatEtsinmi = false;
//			break; 
//		default:
//			Console.WriteLine("Geçersiz işlem seçildi.");
//			break;
//	}
//}
#endregion
#region While
//for (int i = 100; i >1; i/=2)
//{
//    Console.WriteLine(i);
//}


//int i = 0;
//while (true)
//{
//	if (i == 100)
//	{
//		break;
//	}
//    Console.WriteLine(i);
//    i++;
//}
//int i = 0;
//while (i > 10)
//{
//    Console.WriteLine("I"+i);
//    i++;
//}


//int j = 0;
//do
//{
//    Console.WriteLine("J:"+j);
//    j++;
//}
//while(j > 0);
#region Taks1
//Do while istifade ederek userden deyer al ve yoxla eger cut ededdise sonlasin eks halda yeniden istesin.
//do
//{
//	Console.WriteLine("Eded daxil edin");
//	int i = int.Parse(Console.ReadLine());
//	if (i % 2 == 0)
//	{
//        Console.WriteLine("Cut eded tapildi");
//        break;
//	}
//}
//while (true);

#endregion
#region Task2

//while (true)
//{
//	Console.WriteLine("Eded daxil edin");
//	int eded = int.Parse(Console.ReadLine());
//	if (eded % 3== 0 && eded % 2 == 0)
//	{
//		break;
//	}
//}	



#endregion
#region Task3

//5'den 0'a kadar while döngüsü ile ekrana yazan C# programı
//int i = 5; //For un 1 ci hissesi
//while (i > 0 /*For un 2 ci hissesi*/)
//{
//    Console.WriteLine(i);
//    i--; //For un 3 cu hissesi
//}

//for (int j = 5; j > 0; j--)
//{
//    Console.WriteLine(j);
//}


#endregion
#region Task4
//0’dan 1000’e kadar her defe 2 eded artan while döngüsü ile ekrana yazan C# programı
//for (int i = 0; i < 1000; i+=2)
//{
//    Console.WriteLine(i);
//}


//int i = 0;
//while (i<1000)
//{
//	i += 2;
//    Console.WriteLine(i);
//}

#endregion
#endregion
#region Continue

//for (int i = 1; i <= 5; i++)
//{
//    if(i == 3)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 100; i++)
//{
//	if (i % 3 == 0 || i % 2 == 0)
//	{
//		continue;
//	}
//    Console.WriteLine(i);
//}


#endregion

#region Array
#region Intro
//int[] eded = {11,22,33};
//for (int i = 0; i < eded.Length; i++)
//{
//    Console.WriteLine(eded[i]);
//}


//string[] names = { "ali", "nijat", "bob" };
//Console.WriteLine("isim daxil edin");
//string name = Console.ReadLine();

//for (int i = 0; i < names.Length; i++)
//{
//	if (names[i].ToLower() == name.ToLower())
//	{
//        Console.WriteLine("Sistemde sizin adiniz var");
//		break;
//    }

//}
#endregion
#region Task1
// Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi ədəd olduğunu ekrana çıxardan alqoritm yazın.
//int[] ededler = { 1, 2, 45, 76, -34, -89, -90 };
//int musbetSay = 0;
//int menfiSay = 0;
//for (int i = 0; i < ededler.Length; i++)
//{
//	if(ededler[i] > 0)
//	{
//		musbetSay++;
//    }
//	else
//	{
//		menfiSay++;
//	}

//}
//Console.WriteLine($"Musbet Say:{musbetSay}  Menfi say:{menfiSay}");

#endregion
#region Task2
//Array tanimla ve hemin arrayda 3 e bolunenleri cap ele


//int[] numbers = { 1, 3, 6, 5, 95, 30 };
//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] % 3 == 0)
//	{
//		Console.WriteLine(numbers[i]);
//    }
//}
#endregion
#region Methods
int[] numbers = { 3, 5, 72, 7, 26, 7, 82 };

//Uzunluq
//Console.WriteLine(numbers.Length);


//Console.WriteLine("Sort Olunmamis versiyasi");
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//Array.Sort(numbers);

//Console.WriteLine("Sort Olunmus versiyasi");
//for (int i = 0; i < numbers.Length; i++)
//{
//	Console.WriteLine(numbers[i]);
//}


//Tersini yazmaq
//Array.Reverse(numbers);
//for (int i = 0; i < numbers.Length; i++)
//{
//	Console.WriteLine(numbers[i]);
//}

//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] == 5)
//	{
//        Console.WriteLine(i);
//    }
//}


//int index = Array.IndexOf(numbers, 82);
//Console.WriteLine(index);
Console.WriteLine(Array.IndexOf(numbers, 82));




//Tapmiyanda -1 qaytarir
//Console.WriteLine(Array.IndexOf(numbers,92));



#endregion
#endregion
