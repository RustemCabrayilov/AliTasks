using System.Collections;

namespace CollectionsG
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//ArrayList arrayList = new ArrayList();

			//arrayList.Add(1);
			//arrayList.Add(2);
			//arrayList.Add(3);
			//arrayList.Add("Ali");
			//arrayList.Add(true);



			//foreach (var item  in arrayList)
			//{
			//	if((int)item !=null)
			//	{
			//		Console.WriteLine(item);

			//	}
			//}


			//List<int> numbers = new List<int> { 1, 2, 3, 4 };

			//foreach (var item in numbers)
			//{
			//             Console.WriteLine(item);
			////         }
			///
			//numbers.ForEach(x => { Console.WriteLine(x); });

			//Console.WriteLine(numbers.BinarySearch(3));

			//numbers.RemoveRange(1, 2);
			//numbers.ForEach(x => { Console.WriteLine(x); });



			Stack<int> myStack = new Stack<int>();
			myStack.Push(1);
			myStack.Push(2);
			myStack.Push(3);
			myStack.Push(4);
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
			Console.WriteLine(myStack.Pop());
			Console.WriteLine(myStack.Pop());
			Console.WriteLine(myStack.Pop());


		}

	}
}
