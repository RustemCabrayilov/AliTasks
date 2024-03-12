

#region DataTypes
//string name = "Ali";
//name = "Nijat";
//Console.Write("Eded girin:");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine(a);

//Console.Write("Bugun derse getmisen?");
//bool cavab =bool.Parse( Console.ReadLine());
//Console.WriteLine(cavab);

#endregion

#region RiyaziIslemler

//int a = 5;
//int b = 10;
//a += 5;  //a=a+5
//a -= 10; //a=a-10

//a *= 5; //a=a*5
//a += 1;
//a++;

//Console.WriteLine(a+5);
//Console.WriteLine(a);
//Console.WriteLine(++a);



//int a = 5;

//Console.WriteLine(a++);
//Console.WriteLine(++a);

#endregion
#region Sertler IFElse
#region Task1
/*Task 1 : Tələbə İmtahan Qiymətini Daxil Edir. Daxil Edilən İmtahan Qiyməti 0 və 100 Aralığında Olmalıdır.
Əgər Qiymət 91 və 100 Aralığındadırsa A Çap Etsin.
Əgər Qiymət 81 və 90 Aralığındadırsa B Çap Etsin.
Əgər Qiymət 71 və 80 Aralığındadırsa C Çap Etsin.
Əgər Qiymət 61 və 70 Aralığındadırsa D Çap Etsin.
Əgər Qiymət 51 və 60 Aralığındadırsa E Çap Etsin.
Əgər Qiymət 51 -dən Kiçikdirsə Kəsildiniz Çap Etsin.
*/
//Console.Write("Imtahan balinizi daxil edin:");

//double bal =double.Parse(Console.ReadLine());

//if(bal >100 || bal < 0)
//{
//    Console.WriteLine("Duzgun bal daxil edin");
//}
//else
//{
//	if (bal >= 91 && bal <= 100)
//	{
//		Console.WriteLine("Sizin baliniz A");
//	}
//	else if (bal >= 81 && bal < 91)
//	{
//		Console.WriteLine("Sizin baliniz B");
//	}
//	else if (bal >= 71 && bal < 81)
//	{
//		Console.WriteLine("Sizin baliniz C");
//	}
//	else if (bal >= 61 && bal < 71)
//	{
//		Console.WriteLine("Sizin baliniz D");
//	}
//	else if (bal >= 51 && bal < 61)
//	{
//		Console.WriteLine("Sizin baliniz E");
//	}
//	else
//	{
//		Console.WriteLine("Siz imtahanan kesildiniz");
//	}
//}
#endregion
#region Task2
//Console.Write("Yasinizi daxil edin:");
//int yas = int.Parse(Console.ReadLine());
//if (yas <= 0)
//{
//    Console.WriteLine("Yasinizi duzgun daxil edin");
//}
//else
//{
//	if (yas >= 12)
//	{
//		Console.WriteLine("web sayfasina kayit oldunuz");
//	}
//	else
//	{
//		Console.WriteLine("yasinizdan dolayi kayit olamadiniz");
//	}
//}
#endregion
#region Task3
//Console.Write("Alışveriş tutarını giriniz:");
//double tutar = Convert.ToDouble(Console.ReadLine());

//double endirimtutari = 0.0;
//if (tutar >= 300)
//{
//	endirimtutari = 0.20;
//}
//else if (tutar >= 200)
//{
//	endirimtutari = 0.15;
//}
//else if (tutar >= 100)
//{
//	endirimtutari = 0.10;
//}

//double endirimOlunacaqFiyat = tutar * endirimtutari;
//double odenecekTutar = tutar - endirimOlunacaqFiyat;

//Console.WriteLine("Odenilecek mebleg: "+odenecekTutar + " TL");
//Console.WriteLine("Endirim olunan mebleg: "+ endirimOlunacaqFiyat + " TL");

#endregion
#endregion

#region SwitchCase
#region Task1
//Console.Write("Gunu ededle daxil edin:");
//int gun = int.Parse(Console.ReadLine());

//switch (gun)
//{
//	case 1:
//		Console.WriteLine("Monday");
//		break;
//	case 2:
//		Console.WriteLine("Tuesday");
//		break;
//	case 3:
//		Console.WriteLine("Wednesday");
//		break;
//	case 4:
//		Console.WriteLine("Thursday");
//		break;
//	case 5:
//		Console.WriteLine("Friday");
//		break;
//	case 6:
//		Console.WriteLine("Saturday");
//		break;
//	case 7:
//		Console.WriteLine("Sunday");
//		break;
//	default:
//        Console.WriteLine("Duzgun daxil etmediniz..Gunler(1-7)araliginda olur");
//        break;
//}

#endregion
#region Task2

//Console.Write("Isiqforun rengini daxil edin:");
//string reng = Console.ReadLine();
//switch (reng.ToLower())
//{
//	case "yasil":
//        Console.WriteLine("Davam ede bilersen");
//		break;
//	case "sari":
//        Console.WriteLine("Hazirlasin");
//		break;
//	case "qirmizi":
//        Console.WriteLine("Dayanin");
//		break;
//    default:
//        Console.WriteLine("Rengi duzgun daxil edin");
//        break;
//}

#endregion
#endregion


#region Donguler For

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Hello World!");
//}

//for (int i = 0; i < 100; i+=2)
//{
//    Console.WriteLine(i);
//}

//for (int i = 1; i <= 10; i++)
//{
//	for (int j = 1; j <= i; j++)
//	{
//        Console.Write(j+" ");
//    }
//    Console.WriteLine();
//}


//for (int i = 1; i < 100; i *= 2)
//{
//    Console.WriteLine(i);
//}

//for (int i = 100; i >= 1; i-=2)
//{
//    Console.WriteLine(i);
//}


//for (int i =1; i < 100; i=i*3)
//{
//    Console.WriteLine(i);
//}

//int[setir,sutun]
int[,] ededler = { { 1, 2, 3 }, { 4,5,6} ,{ 7,8,9} };


for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		Console.Write(ededler[i,j]+" ");
    }
	Console.WriteLine();
}


#endregion
