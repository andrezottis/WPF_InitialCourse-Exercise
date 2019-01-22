using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class Divisible
    {
        public static void CheckDivisible ()
        {
            
            var count = 0;

            for (int i = 1; i <= 100; i++)
            {
               if (i % 3 ==0)
                {
                    count++;
                    Console.WriteLine("the number is: {0}", i);
                }

            }

            Console.WriteLine("The total of number disivible by 3 are: {0}", count);
            Console.ReadLine();

        }
    }
}
