using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		#region Convention 1
		//public Group Group { get; set; }
		#endregion
		#region Convention 3
		//public Group Group { get; set; }
		#endregion
		#region Convention 4
		public int GroupId { get; set; }
		public Group Group { get; set; }
		#endregion

		public StudentAddress studentAddress { get; set; }

		public override string ToString()
		{
			return "ID:" + Id + " Name:" + Name + " Surname:" + Surname;
		}
	}
}
