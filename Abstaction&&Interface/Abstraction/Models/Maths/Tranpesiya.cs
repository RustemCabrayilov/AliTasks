using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models.Maths
{
	public class Tranpesiya : Shape
	{
		private double a;
		private double b;
		private double h;

        public Tranpesiya(double a , double b , double h)
        {
            this.a = a;
			this.b = b;
			this.h = h;
        }

        public override double GetArea()
		{
			double s = ((a + b) / 2) *h;
			return s;
		}

		public override double GetPerimeter()
		{
			double x =Math.Abs((b - a) / 2);

			double yanTeref =Math.Sqrt(Math.Pow(x, 2) + Math.Pow(h, 2));

			double p = a + b + yanTeref * 2;
			return p;
		}
	}
}
