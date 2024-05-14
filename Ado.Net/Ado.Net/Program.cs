using Microsoft.Data.SqlClient;

namespace Ado.Net
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region CreateTable
			//string connectionString = "Server=DESKTOP-NIJAT;Database=UniversityDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true";

			//SqlConnection connection = new SqlConnection(connectionString);


			//string commandString = "create table Teacher(\r\nId int Identity Primary key,\r\nName nvarchar(50),\r\nSurname nvarchar(50),\r\nAddress nvarchar(MAX),\r\nAge int, \r\n);";

			//SqlCommand command = new SqlCommand(commandString, connection);


			//connection.Open();
			//command.ExecuteNonQuery();
			//connection.Close();


			#endregion

			#region InsertValue

			//try
			//{

			//             Console.Write("Enter Teacher Name:");
			//	string name = Console.ReadLine();

			//             Console.Write("Surname:");
			//	string surname = Console.ReadLine();

			//	Console.Write("Address:");
			//	string address = Console.ReadLine();

			//	Console.Write("Age:");
			//	int age = int.Parse(Console.ReadLine());

			//             string connectionString = "Server=DESKTOP-NIJAT;Database=UniversityDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true";

			//	SqlConnection connection = new SqlConnection(connectionString);


			//	string commandString = $"Insert into Teachers values('{name}','{surname}','{address}',{age})";


			//             SqlCommand command = new SqlCommand(commandString, connection);


			//	connection.Open();
			//	command.ExecuteNonQuery();
			//	connection.Close();
			//}
			//catch (Exception ex)
			//{
			//             Console.WriteLine(ex.Message);
			//             Console.WriteLine("SQl Connection Problem");
			//         }


			#endregion

			#region SelectValues

			//try
			//{
			//	string connectionString = "Server=DESKTOP-NIJAT;Database=UniversityDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true";

			//	SqlConnection connection = new SqlConnection(connectionString);


			//	string commandString = $"Select * from Teachers";


			//	SqlCommand command = new SqlCommand(commandString, connection);


			//	connection.Open();

			//	SqlDataReader reader = command.ExecuteReader();


			//	while (reader.Read())
			//	{
			//		//Console.WriteLine(reader["Id"]);
			//		Console.WriteLine("ID:" + reader["Id"] + "  Name:" + reader["Name"] + "  Surname:" + reader["Surname"]
			//   + "  Address:" + reader["Address"] + "  Age:" + reader["Age"]);
			//	}

			//	connection.Close();
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//	Console.WriteLine("SQl Connection Problem");
			//}



			#endregion

			#region DeleteUpdatevalue

			try
			{
				Console.Write("Enter Id:");
				int id = int.Parse(Console.ReadLine());

				Console.Write("Enter Column Name:");
				string column = Console.ReadLine();

				Console.Write("Data:");
				string data = Console.ReadLine();


                string connectionString = "Server=DESKTOP-NIJAT;Database=UniversityDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true";

				SqlConnection connection = new SqlConnection(connectionString);


				//string commandString = $"Delete  from Teachers Where Id = {id}";
				string commandString = $"update Teachers Set {column} = '{data}' Where Id ={id};";


				SqlCommand command = new SqlCommand(commandString, connection);


				connection.Open();

				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}


			#endregion

		}
	}
}
