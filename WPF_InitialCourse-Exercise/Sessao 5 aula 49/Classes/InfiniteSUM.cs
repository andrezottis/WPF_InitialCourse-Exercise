using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class InfiniteSUM
    {
        public static void AskSum()
        {

            var totalSum = 0;
            while (true)
            {
                Console.Write("Please, enter a number:");
                var input = Console.ReadLine();
                if (input != "ok")
                {
                    totalSum += int.Parse(input);
                    continue;
                }

                break;

            }
            Console.WriteLine("Tem SUM of insert numbers is: {0}", totalSum);
            Console.Read();
        }
    }
}
