using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS5._1._4
{
    class Program
    {
        //Определить количество   нечетных положительных элементов, стоящих на четных местах.

        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int plus = 0;
            for (int i = 0; i < 20; i+=2)
            {               
                
                    if (array[i] > 0 && array[i] % 2 != 0)
                    {              
                    plus++;
                    }                
            }            
            Console.WriteLine(plus);            
            Console.ReadKey();
        }
    }
}
