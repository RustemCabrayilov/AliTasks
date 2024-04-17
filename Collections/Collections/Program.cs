using System.Collections;

namespace Collections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region NonGeneric Collections
			#region ArrayList
			//ArrayList arrayList = new ArrayList();
			//arrayList.Add(1);
			//arrayList.Add(2);
			//arrayList.Add("Ali");
			//arrayList.Add(false);
			//arrayList.Add(false);

			//arrayList.AddRange(new int[] { 1, 2, 3 });

			//arrayList.RemoveRange(2, 3);


			//foreach (var data in arrayList)
			//{
			//	Console.WriteLine(data);
			//}
			#endregion
			#region StackQueue
			//Stack stack = new Stack();

			//stack.Push("Nijat1");
			//stack.Push("Ali1");
			//stack.Push("Nijat2");
			//stack.Push("Ali2");
			//stack.Push("Ali");
			////stack.Push(2);


			////while(stack.Count > 0)
			////{
			////             Console.WriteLine(stack.Pop());
			////             Console.WriteLine(stack.Count);

			////         }
			//stack.Pop();	
			//         Console.WriteLine(stack.Peek());

			//         Console.WriteLine(stack.Contains("Ali2"));


			//Queue queue = new Queue();
			//queue.Enqueue(1);
			//queue.Enqueue(2);
			//queue.Enqueue(3);
			//queue.Enqueue(4);
			//queue.Enqueue(5);

			//foreach (var item in queue)
			//{
			//             Console.WriteLine(item);
			//         }

			//while(queue.Count > 0)
			//{
			//             Console.WriteLine(queue.Dequeue());
			//             Console.WriteLine("Count: "+queue.Count);
			//         }
			//Console.WriteLine(queue.Peek());
			#endregion
			#region SortedList
			//SortedList sortedList = new SortedList();
			//sortedList.Add("2", "Ali");
			//sortedList.Add("&", "Nijat");
			//sortedList.Add("$", 2);
			//sortedList.Add("5", "Nijat2");
			//sortedList.Add("1", "Mammad");

			//foreach (var item in sortedList.Values)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#endregion
			#region Generic Collections
			//Stack<string> strings = new Stack<string>();

			//Queue<int> ints = new Queue<int>();

			//SortedList<int,string> datas = new SortedList<int,string>();
			//datas.Add(2, "Ali");


			//Dictionary<int,string> datas2 = new Dictionary<int,string>();

			//datas2.Add(2, "abc2");
			//datas2.Add(3, "abc3");
			//datas2.Add(1, "abc1");

			//foreach (var data in datas2.Values)
			//{
			//             Console.WriteLine(data);
			//         }

			//HashSet<string> set = new HashSet<string>();

			//set.Add("abc");
			//set.Add("c");
			//set.Add("bda");
			//set.Add("c");

			//foreach (string s in set)
			//{
			//	Console.WriteLine(s);
			//}

			int Sixteen = 0b001_0000;
            Console.WriteLine(Sixteen);

            #endregion
        }
	}
}
