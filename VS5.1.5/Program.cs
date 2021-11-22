using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS5._1._5
{
    class Program
    {
        //Сформировать двумерный массив размера NxN
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое чисел ");
            int n = Convert.ToInt32(Console.ReadLine());         
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = 1 - (i + j) % 2;
                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }

    }
}

