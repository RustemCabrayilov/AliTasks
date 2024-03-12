#region For ForEach

//for(int i = 0; i < 10; i+=2)
//{
//    Console.WriteLine(i);
//}


//for(int i = 10; i > 0; i -= 2)
//{
//    Console.WriteLine(i);
//}



//int[] numbers = { 1, 4, 6, 7, 8, 9 };


//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

#endregion

#region While DoWhile

//int i = 0;
//int j = 0;


//while (i<0)
//{
//    Console.WriteLine("Ali");
//    i++;
//}


//do
//{
//	Console.WriteLine("Nijat");
//	j++;
//}
//while (j < 0);


//char i = 'A';

//do
//{

//	Console.WriteLine(i);
//	i++;

//} while (i <= 'Z');

//Console.ReadLine();



#endregion

#region Break Continue

//Break
//for (int i = 0; i < 10; i++)
//{
//	if (i == 5)
//	{
//		break;
//	}
//	Console.WriteLine(i);
//}
////Isliyecek
//Console.WriteLine("Ali");

//Continue
//for (int i = 0; i < 10; i++)
//{
//	if (i == 5)
//	{
//		continue;
//	}
//	Console.WriteLine(i);
//}


//Return
//for (int i = 0; i < 10; i++)
//{
//	if (i == 5)
//	{
//		return;
//	}
//	Console.WriteLine(i);
//}
////Islemiyecek
//Console.WriteLine("Ali");

#endregion

#region Arrays ArrayList

//int[] numbers = { 2, 5, 7, 8, 3, 5, 10 };

//Console.WriteLine(numbers.Max(x => x));

//int max = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//	if (numbers[i] > max)
//	{
//		max = numbers[i];	
//	}
//}
//Console.WriteLine("Max Value : "+max);

using System.Collections;

ArrayList datas = new ArrayList();

datas.Add(0);
datas.Add(1);
datas.Add(14);
datas.Add(-3);
datas.Add(11);
datas.Add(5);

//Hansini Silmek istiyirsen
//datas.Remove(11);

//Hansi indexdekin silmek istiyirsen
//datas.RemoveAt(2);

//datas.Add("Ali");

//Istenilen Indexe elave eliyir
//datas.Insert(2, "Ali");

//Azdan Coxa ve ya Elifba sirasina uygun
//datas.Sort();

//datas.Reverse();

//for (int i = 0; i < datas.Count; i++)
//{
//    Console.WriteLine(datas[i]);
//}

//List<int> numbers = new List<int>();
//numbers.Add(0);
//numbers.Add(1);
//numbers.Add(14);
//numbers.Add(-3);
//numbers.Add(11);
//numbers.Add(5);

//Console.WriteLine(numbers.Max());

#endregion

#region TaskIfElse
//float odeyeceyimebleg;
//Console.Write("meblegi girin: ");
//float xerc = float.Parse(Console.ReadLine());

//if(xerc >= 100 && xerc <200)
//{
//	odeyeceyimebleg = (float)(xerc * 0.9);
//}
//else if(xerc >= 200 && xerc <300 )
//{
//	odeyeceyimebleg = (float)(xerc * 0.85);
//}
//else 
//{
//	odeyeceyimebleg = (float)(xerc * 0.8);
//}

//Console.WriteLine("Sizin xerciniz "+odeyeceyimebleg);
#endregion

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(1);
numbers.Add(2);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(-6);


//for (int i = 0; i < numbers.Count; i++)
//{
//	int count = 1;
//	for (int j = 1; j < numbers.Count; j++)
//	{
//		if (numbers[i] == numbers[j])
//		{
//			count++;

//		}
//	}
//	Console.WriteLine("Number:" + numbers[i] + "  Count: " + count);
//}

for (int i = 0; i < numbers.Count; i++)
{
	for (int j = i + 1; j < numbers.Count; j++)
	{
		int temp;
		if (numbers[i] > numbers[j])
		{
			temp = numbers[j];
			numbers[j] = numbers[i];
			numbers[i] = temp;
		}
	}
}

for (int i = 0; i < numbers.Count; i++)
{
	int count = 1;
	for (int j = i + 1; j < numbers.Count; j++)
	{
		if (numbers[i] == numbers[j])
		{
			count++;
		}
		else
		{
			i = j-1 ;
			break;
		}
	}
	Console.WriteLine("Number:" + numbers[i] + "  Count:" + count);
}

