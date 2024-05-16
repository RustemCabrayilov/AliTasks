using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ORM.Context;
using ORM.Models;

namespace ORM
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Student student = new Student()
			//{
			//	Name = "Ali2",
			//	Surname = "Agayev",
			//	Address = "28 May"
			//};

			//SMDbContext context = new SMDbContext();
			using (SMDbContext context = new SMDbContext())
			{

				#region Add
				//EntityEntry entityState = context.Students.Add(student);

				//Console.WriteLine(entityState.State);
				//context.SaveChanges();
				//Console.WriteLine(entityState.State);

				#endregion
				#region Query

				//var students = from s in context.Students
				//						 select new
				//						 {
				//							 Id = s.Id,
				//							 Name = s.Name,
				//							 Surname = s.Surname,
				//							 Address = s.Address,
				//						 };

				//foreach(var student in students)
				//{
				//                Console.WriteLine(student.Name);
				//            }


				//var students = context.Students.Where(s=> s.Name.ToLower().Contains("ali"));

				//foreach (var student in students)
				//{
				//                Console.WriteLine(student);
				//            }

				#endregion

				#region UpdateRemove

				//var student = context.Students.Where(s => s.Id ==6).FirstOrDefault();


				//context.Students.Remove(student);
				//context.SaveChanges();


				var student = context.Students.Where(s=>s.Id ==7).FirstOrDefault();
				if (student != null)
				{
                    Console.WriteLine(context.Entry(student).State);
					student.Name = "ALi";
					Console.WriteLine(context.Entry(student).State);


					context.SaveChanges();
					Console.WriteLine(context.Entry(student).State);

				}


				#endregion

			};


		}
	}
}
