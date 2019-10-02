using System;

namespace Task5b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки");
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Выбранная точка ({x};{y})");
            if ((x*x+y*y<1) && (x>=0))
            {
                Console.WriteLine("Выбранная точка входит в заштрихованную область");
            }
            else
            {
                Console.WriteLine("Выбранная точка не входит в заштрихованную область");
            }
        }
    }
}
