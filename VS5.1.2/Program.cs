using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS5._1._2
{
    class Program
    {
        //Определить сумму максимального и минимального элементов массива
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            int sum = 0;
            foreach (int a in array)
            {
                if (a > max)
                    max = a;

            }
            Console.WriteLine("Наибольшее значение массива равно {0,2}", max);
            foreach (int a in array)
            {
                if (a < min)
                    min = a;

            }
            Console.WriteLine("Наименьшее значение массива равно {0,2}", min);
           //sum = min + max;
            //Console.WriteLine("Сумма наибольшего значения {0,2} и наименьшего значения {1,2}  равна {2,2}", max, min, sum);
            Console.WriteLine("{0,2} + {1,2} = {2,2}", max, min, sum=min+max);
            Console.ReadKey();
        }
    }
}
