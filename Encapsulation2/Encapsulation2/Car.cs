using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
	public class Car
	{
		private string _marka;
		private string _model;
		private string _color;
		private double _salary;

		public string Marka
		{
			get { return _marka; }
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
					_marka = value;
				else
					throw new Exception("Deyer bos gele bilmez");
			}

		}
		public string Model
		{
			get { return _model; }
			set
			{
				_model = value;
			}

		}
		public string Color
		{
			get { return _color; }
			set
			{
				_color = value;
			}
		}
		public double Salary
		{
			get { return _salary; }
			set
			{
				_salary = value;
			}
		}
	}
}
