using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS5._1._1
{
    class Program
    {
        //Метод находит среднее арифметическое значение из семи элементов массива.
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Console.WriteLine("Введите семь чисел ");
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", array[i]);
                S += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее значение равно {0:f2}", S / 7);

            Console.ReadKey();
        }
    }
}
