using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	public class Triangle
	{
		private double a = 0;
		private double b = 0;
		private double c = 0;

		public double A {  
			get { return a; }
			set {  
				if (value > 0)
					a = value;
				else
					Console.WriteLine("Стороны треугольника должны быть положительными");
				
			} 
		}
		public double B
		{
			get { return b; }
			set
			{
				if (value > 0)
					b = value;
				else
					Console.WriteLine("Стороны треугольника должны быть положительными");

			}
		}
		public double C
		{
			get { return c; }
			set
			{
				if (value > 0)
					c = value;
				else
					Console.WriteLine("Стороны треугольника должны быть положительными");
			}
		}
        public Triangle()
        {
        }
		public Triangle(double storona_a, double storona_b, double storona_c)
		{
			this.a = storona_a;
			this.b = storona_b;
			this.c = storona_c;
		}
		public void triangleInfo()
		{
            Console.WriteLine($"Треугольник с сторонами {this.a} {b} {c}");
        }
		public void isTrianglePr()
		{
			if ( a * a + b * b == c * c)
			{
                Console.WriteLine("Прямоугольный");
			}
			else
			{
				Console.WriteLine("Не прямоугольный");
			}
		}
		public double triangleSquare()
		{
			return a * b / 2;
		}

	}
}
