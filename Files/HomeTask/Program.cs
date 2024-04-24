namespace HomeTask
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			list.Add(6);
			list.Add(8);
			list.Add(4);
			list.Add(2);
			list.Add(5);
			#region EliHelli
			//	int maxresult =list.Max();
			//         int minimumsum= list.Sum()-maxresult;
			//          Console.WriteLine("minimum cem :" +minimumsum);

			//int minimumresult =	list.Min();
			//	int maximumsum= list.Sum()- minimumresult;
			//          Console.WriteLine("maximum cem :" + maximumsum);

			#endregion

			#region NicatHelli

			List<int> newList = list ;
			newList.Sort();
			int maxCem = 0;
			int minCem = 0;
			foreach (int i in newList) {
				
            }
			

			#endregion
		}
	}
}
