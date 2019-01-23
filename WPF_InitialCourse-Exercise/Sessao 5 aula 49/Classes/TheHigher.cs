using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class TheHigher
    {
        public static void GetHigher()
        {
            Console.WriteLine("Please, how many number you want to insert?");
            int sizeNumber = int.Parse(Console.ReadLine());
            int [] numbers = new int [sizeNumber];
            for (int i = 0; i < sizeNumber; i++)
            {
                Console.Write("Please,type a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine( "The higher number is: {0}", numbers.Max());
            Console.Read();
        }
    }
}
