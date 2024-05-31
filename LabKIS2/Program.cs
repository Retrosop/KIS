using System;
using System.IO;

namespace Lab2
{
    class Par
    {
        private double a, b, c;
        public double GetV()
        {
            return a * b * c;
        }

        public double GetS()
        {
            return 2 * (a * b + b * c + a * c);
        }

        public void Info()
        {
            String str = "Информация о параллелепипеде";
            Console.WriteLine(str);
            Console.WriteLine(string.Format(
                "A = {0:0.000}, B = {1:0.000}, C = {2:0.000}", a, b, c));
            Console.WriteLine(string.Format("V = {0:0.000}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.000}", GetS()));
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Sphere
    {
        //V = 4/3 * Pi * R^3
        //S = 4 * Pi * R^2
        private double R;

        public double Volume()
        {
            double V = 4 / 3 * Math.PI * Math.Pow(R, 3);
            return V;
        }

        public double Square()
        {
            double S = 4 * Math.PI * Math.Pow(R,2);
            return S;
        }

        public void Info()
        {
            Console.WriteLine("Информация о шаре");
            Console.WriteLine(string.Format("Радиус шара R = {0:0.00}, диаметр шара D = {1:0.00}", R, R*2));
            Console.WriteLine(string.Format("Объём шара: {0:0.00}", Volume()));
            Console.WriteLine(string.Format("Площадь шара: {0:0.00}", Square()));
        }

        public void Load()
        {
            R = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetIn(new_in);
            Console.SetOut(new_out);
#endif
            Par p = new Par();
            p.Load();
            p.Info();
            Console.WriteLine("\n");
            Sphere s = new Sphere();
            s.Load();
            s.Info();
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}