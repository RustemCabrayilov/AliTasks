using SMS.App.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Models
{
	public class Student : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int GroupId { get; set; }
		public Group Group { get; set; }
		public override string ToString()
		{
			return "Name:" + Name + " Surname:" + Surname + " Group Number:"+ Group.Name;
		}
	}
}
