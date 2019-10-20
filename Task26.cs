/**

* @author Ivan Sidenko

* 11-912

* Task 26

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
            int max = 0;
            int savei = 0;
            int counti = 1;
            for (int j = 0; j < n; j++)
            {
                int savej = j;
                int smax = 0;
                int count = 0;
                for (int i = 0; j < n && i < m; i++)
                {
                    count++;
                    smax += a[i, j];
                    j++;
                    savei = i;
                }
                j = 0;
                if (count < m && count < n)
                {
                    for (int i = m - counti; i < m; i++) 
                    {
                        smax += a[i, j];
                        j++;
                    }
                    counti++;
                }
                if (smax > max) max = smax;
                j = savej;
            }
            Console.Write($"Ответ: {max}");
        }
    }
}
