using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
	internal class Car
	{
		public string Model { get; set; }
		public double EngineSize { get; set; } 
		public string Color { get; set; }
		public double HorsePower { get; set; }
        public string Marka { get; set; }

		public void Drive()
		{
            Console.WriteLine("Driver drives "+Model);
        }
    }
}
