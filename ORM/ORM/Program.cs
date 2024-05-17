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


				//var student = context.Students.Where(s=>s.Id ==7).FirstOrDefault();
				//if (student != null)
				//{
				//                Console.WriteLine(context.Entry(student).State);
				//	student.Name = "ALi";
				//	Console.WriteLine(context.Entry(student).State);


				//	context.SaveChanges();
				//	Console.WriteLine(context.Entry(student).State);

				//}


				#endregion

				#region Conventions

				//Group group = new Group()
				//{
				//	GroupName = "PB101"
				//};
				//Group group2 = new Group()
				//{
				//	GroupName = "PF501"
				//};


				//context.Groups.AddRange(group,group2);


				//Group group = context.Groups.Where(g => g.GroupName == "PB101").FirstOrDefault();
				//if (group != null)
				//{
				//	Student student = new Student()
				//	{
				//		Name = "Nijat",
				//		Surname = "Soltanov",
				//		GroupId = group.Id,
				//	};
				//	context.Add(student);
				//	context.SaveChanges();

				//}

				//Student student = context.Students.Where(s => s.Id == 9).FirstOrDefault();

				//StudentAddress studentAddress = new StudentAddress()
				//{
				//	Country = "Azerbaijan",
				//	City = "Baku",
				//	State = "Savalan",
				//	Address = "Adress123",
				//	Student = student
				//	//StudentId = student.Id
				//};
				//context.Add(studentAddress);
				//context.SaveChanges();


				//Group group = new Group()
				//{
				//	GroupName = "P136",
				//	Students = new List<Student>()
				//	{
				//		new Student()
				//		{
				//			Name = "Isa",
				//			Surname= "Sadigov",
				//			studentAddress = new StudentAddress()
				//			{
				//					Country = "Azerbaijan",
				//                    City = "Baku",
				//            	    State = "Xalqlar",
				//              	    Address = "Adress123",
				//			}
				//		},
				//	}
				//};
				//context.Groups.Add(group);
				//context.SaveChanges();





				#endregion

			};


		}
	}
}
