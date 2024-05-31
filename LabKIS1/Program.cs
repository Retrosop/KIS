using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine("Лабораторная работа №1: Разработка консольного приложения");
            Console.WriteLine("Выполнила: Аристова Дарья Андреевна");
            Console.WriteLine("Группа: 1201. Шифр специальности: 44.03.5 Педагогическое образование");
            Console.WriteLine("Дата рождения: 23.05.2002");
            Console.WriteLine("Населённый пункт: г. Биробиджан");
            Console.WriteLine("Любимый предмет в школе: Математика");
            Console.WriteLine("Хобби и интересы: Чтение книг\n");

            Console.WriteLine("Задание №2. Вариант 1");
            //F = a_1 + b - a * (x + y5)
            double F = 0;
            int a_1 = 4;
            double b = 1.6f, a = 67438.3f;
            long x = 199, y5 = 512;
            F = a_1 + b - a * (x + y5);
            Console.WriteLine("Результат вычисления выражения F = " + F);
        }
    }
}