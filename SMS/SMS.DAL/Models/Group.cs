using SMS.App.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Models
{
	public class Group : BaseEntity
	{
		public string Name { get; set; }
		public ICollection<Student> Students { get; set; }
		public override string ToString()
		{
			return "Id:" + Id + "  Name:" + Name ;
		}
	}
}
