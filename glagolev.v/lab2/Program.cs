namespace lab2
{
	class MyProgram
	{
		static void Main()
		{
			Triangle triangle1 = new Triangle();
			//triangle.A = - 1;
			Triangle triangle2 = new Triangle(3,4,5);
			triangle2.triangleInfo();
			triangle2.isTrianglePr();
			var pl = triangle2.triangleSquare();
            Console.WriteLine($"Площадь треугольника {pl}");
        }
	}
}