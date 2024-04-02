using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models.Maths
{
	public class Rectangle : Shape
	{
		private double a;
		private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
			this.b = b;	
        }

        public override double GetArea()
		{
			double s = a * b;
			return s;
		}

		public override double GetPerimeter()
		{
		    double perimeter = 2*(a+b);
		    return perimeter;
		}
	}
}
