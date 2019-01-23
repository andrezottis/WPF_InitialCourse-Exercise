using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type the number to the exercise: \n" +
                "1. Count divisibles \n" +
                "2. Infinite SUM \n" +
                "3. Factoration \n" +
                "4. Guess the Number \n" +
                "5. The higher number");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Divisible.CheckDivisible();
                    break;
                case 2:
                    InfiniteSUM.AskSum();
                    break;
                case 3:
                    Factorial.NumberFactorial();
                    break;
                case 4:
                    GuessTheNumber.Guess();
                    break;
                case 5:
                    TheHigher.GetHigher();

                    break;
                default:
                    break;
            }
        }
    }
}
