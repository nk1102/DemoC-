using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_
{
	public class Inheritance
	{

		public class Shape
		{
			public void Display()
			{
				Console.WriteLine("Shape is Being displayed");

			}

		}



		public class Circle : Shape {
			public void Display()
			{
				Console.WriteLine("Circle is being called from the Circle Class");
			}
		}
	}
}
