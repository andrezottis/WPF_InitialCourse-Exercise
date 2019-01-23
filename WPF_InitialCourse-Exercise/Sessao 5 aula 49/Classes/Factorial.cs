using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class Factorial
    {
        public static void NumberFactorial()
        {
            Console.Write("Please, type a number:");
            int input = int.Parse(Console.ReadLine());
            var total = input;
            for (int i = 1; i < input; i++)
            {
                total = total * i;
                
            }
            Console.WriteLine("The result is: " + total);
            Console.Read();
        }
    }
}
