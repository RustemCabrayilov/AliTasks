using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models.Maths
{
	internal class Triangle : Shape
	{
		private double a;
		private double b;
		private double c;
        public Triangle(double a, double b, double c)
        {
		    this.a = a;
			this.b = b;
			this.c = c;
        }
        public override double GetArea()
		{
			double p = GetPerimeter()/2;
			double s = Math.Sqrt (p * (p - a) * (p - b) * (p - c));
			return s;
		}

		public override double GetPerimeter()
		{
			double Perimetr = a+ b+ c;
			return Perimetr;


		}
	}
}
