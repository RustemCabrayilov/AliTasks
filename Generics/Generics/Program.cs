using Generics.DataStores;
using Generics.Models;
using System.Collections;

namespace Generics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataStore<string> dataStoreString = new DataStore<string>();
			dataStoreString.GetType();
			dataStoreString.Datas.Add("Ali");
			dataStoreString.Datas.Add("Nijat");


			DataStore<int> dataStoreInt = new DataStore<int>();
			dataStoreInt.GetType();
			dataStoreInt.Datas.Add(17);
			dataStoreInt.Datas.Add(20);


			DataStore<float> dataStoreFloat = new DataStore<float>();


			DataStore<bool> dataStoreBool = new DataStore<bool>();
			dataStoreBool.GetType();
			dataStoreBool.Datas.Add(true);
			dataStoreBool.Datas.Add(true);


			DataStore<Person> dataStorePersons = new DataStore<Person>();
			dataStorePersons.GetType();

			DataStore<Teacher> dataStoreTeachers = new DataStore<Teacher>();
			dataStoreTeachers.GetType();


			DataStore<List<string>> dataStoreList = new DataStore<List<string>>();
			//dataStoreTeachers.GetType();


		}
	}
}
