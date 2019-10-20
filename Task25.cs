/**

* @author Ivan Sidenko

* 11-912

* Task 25

*/
using System;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк/стобцов для квадратной матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            Console.WriteLine("Заполните эту матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Полученная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            int imax = -1;
            int jmax = -1;
            int max = -2147483648;
            int smax = 0;
            int savei;
            for (int i = 1; i < n; i++)
            {
                savei = i;
                for (int j = 0; i < n; j++)
                {
                    smax += a[i, j];
                    i++;
                }
                i = savei;
                if (smax > max)
                {
                    max = smax;
                    imax = i;
                }
                smax = 0;
            }
            int savej;
            for (int j = 1; j < n; j++)
            {
                savej = j;
                for (int i = 0; j < n; i++)
                {
                    smax += a[i, j];
                    j++;
                }
                j = savej;
                if (smax > max)
                {
                    max = smax;
                    imax = 0;
                    jmax = j;
                }
                smax = 0;
            }
            Console.Write("Ответ: ");
            if (jmax == -1)
            {
                for (int i = imax; i < n; i++)
                {
                    for (int j = 0; i < n; j++)
                    {
                        Console.Write($"{a[i, j]} ");
                        i++;
                    }
                }
            }
            else
            {
                for (int j = jmax; j < n; j++)
                {
                    for (int i = 0; j < n; i++)
                    {
                        Console.Write($"{a[i, j]} ");
                        j++;
                    }
                }
            }
        }
    }
}
