using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models
{
	public class Group
	{
		public int Id { get; set; }
		public string GroupName { get; set; }
		#region Convention 2
		//public ICollection<Student> Students { get; set; }
		#endregion
		#region Convention 3
		//public ICollection<Student> Students { get; set; }
		#endregion
		#region Convention 4
		public ICollection<Student> Students { get; set; }
		#endregion
	}
}
