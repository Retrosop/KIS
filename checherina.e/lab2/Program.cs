namespace lab2
{
	class MyProgram
	{
		static void Main()
		{
			Ball ball1 = new Ball();

			Ball ball2 = new Ball(4);
			ball2.ballInfo();
			ball2.ballDiametr();
			var diametr = ball2.ballDiametr();
			var pl = ball2.ballSquare();
			var ob = ball2.ballVolume();
			Console.WriteLine($"Диаметр шара {diametr}");
            Console.WriteLine($"Площадь шара {pl}");
			Console.WriteLine($"Объём шара {ob}");
        }
	}
}