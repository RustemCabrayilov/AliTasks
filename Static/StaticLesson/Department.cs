using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLesson
{
	public static class Department
	{
        private static string Name { get; set; }
        private static string Description { get; set; } 
		
		public static void GetName() {

            Console.WriteLine("Name: "+ Name);
        }

        static Department()
        {
            Name = "IT";
            Description = "dasdasd";
            Console.WriteLine("Static Constructor isledi");
        }
    }
}
