using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models
{
	public class Order
	{
		[Key]
		public int OrderNumber { get; set; }
		[MaxLength(200)]
		public string? Description { get; set; }
		[ForeignKey("Student")]
		public int TelebeId { get; set; }
		public Student Student { get; set; }
		[NotMapped]
		public int CountryCode { get; set; }

	}
}
