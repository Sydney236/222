/**

* @author Ivan Sidenko

* 11-912

* Task 27

*/
using System;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Заполните эту матрицу");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Полученная матрица:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите количество столбцов второй матрицы");
            int p = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[n, p];
            Console.WriteLine("Заполните эту матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Полученная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[m, p];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    int s = 0;
                    for (int w = 0; w < n; w++)
                    {
                        s += a[i, w] * b[w, j];
                    }
                    c[i, j] = s;
                }
            }
            Console.WriteLine("Результат умножения матриц:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write($"{c[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
