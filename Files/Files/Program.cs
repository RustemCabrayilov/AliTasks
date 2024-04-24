using System.IO;
using System.Text;

namespace Files
{
	public class Program
	{
		static async Task  Main(string[] args)
		{
			string path = @"C:\Users\Nijat\OneDrive\Desktop\Ali\Files\Files\testFileStream1.txt";
			string path2 = @"C:\Users\Nijat\OneDrive\Desktop\Ali\Files\Files\test2.txt";
			string text = "Azərbaycan Prezidenti İlham Əliyevin Qırğızıstan Prezidenti Sadır Japarov ilə məhdud tərkibdə görüşü başlayıb. “Qafqazinfo” xəbər verir ki, bu barəde";


			#region File
			////File.Create(path);



			//List<string> fileDatas =  (await File.ReadAllLinesAsync(path)).ToList();



			//FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write);

			//Icindeki ne varsa silir ve text-i elave edir
			//await File.WriteAllTextAsync(path, text);

			List<string> list = new List<string>();
			//list.AddRange(fileDatas);
			list.Add("Ali2");
			list.Add("Nijat2");



			//await File.WriteAllLinesAsync(path, list);


			//string path2 = @"C:\Users\Nijat\OneDrive\Desktop\Ali\Files\Files\test3.txt";


			//await File.AppendAllTextAsync(path2, text);

			//File.Delete(path2);

			//await File.AppendAllLinesAsync(path2, list);


			//File.Copy(path, path2);
			#endregion
			#region FileStream

			//FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);

			//StreamWriter writer = new StreamWriter(fs);

			//writer.Write(text);

			//writer.Close();

			//using(StreamWriter sw = new StreamWriter(fs))
			//{
			//	sw.WriteLine(text);
			//}

			//using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
			//{

			//	using (StreamReader sr = new StreamReader(fs))
			//	{
			//		string textFile = sr.ReadToEnd();
			//		Console.WriteLine(textFile);
			//	}
			//}
			string newText = "Salam qardassssssadnasjkdasjdajskdnasjdasdnjkasdjkasdbjkas";


			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				//byte[] dataToWrite = System.Text.Encoding.UTF8.GetBytes(newText);

				//fs.Write(dataToWrite,0, dataToWrite.Length);


				byte[] buffer = Encoding.Default.GetBytes(newText);
				foreach (byte b in buffer)
				{
                    await Console.Out.WriteLineAsync(b.ToString());
                }
				// запись массива байтов в файл
				await fs.WriteAsync(buffer, 0, buffer.Length);
			}

			#endregion


		}
	}
}
