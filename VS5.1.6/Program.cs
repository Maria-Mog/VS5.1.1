using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS5._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив чисел NxN ");
            Console.WriteLine("Введите число N1:1 ");
            int n11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N1:2 ");
            int n12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N1:3 ");
            int n13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N2:1 ");
            int n21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N2:2 ");
            int n22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N2:3 ");
            int n23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N3:1 ");
            int n31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N3:2 ");
            int n32 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N3:3 ");
            int n33 = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[3, 3] { { n11, n12, n13 }, { n21, n22, n23 }, { n31, n32, n33 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine();               
                
            }
            int sum1 = n11 + n12 + n13;
            int sum2 = n21 + n22 + n23;
            int sum3 = n31 + n32 + n33;
            if ((sum1 == sum2) && (sum1 == sum3))
            {
                Console.WriteLine("Получили магический квадрат");
            }
            else
            {
                Console.WriteLine("Полученный квадрат не являестся магическим");
            }
            Console.ReadKey();

        }

        
}
}

