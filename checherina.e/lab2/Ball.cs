using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	public class Ball
	{
		private double r = 0;

		public double R {  
			get { return r; }
			set {  
				if (value > 0)
					r = value;
				else
					Console.WriteLine("Радиус сферы должен быть положительным");
				
			} 
		}
        public Ball()
        {
        }
		public Ball(double radius)
		{
			this.r = radius;

		}
		public void ballInfo()
		{
            Console.WriteLine($"Шар с радиусом {r}");
        }
		public double ballDiametr()
		{
			return r * 2;
		}
        public double ballSquare()
		{
			return r * r * 4 * double.Pi;
		}

		public double ballVolume() {
			return r * r * r * 4/3 * double.Pi;
		}
    }
}
