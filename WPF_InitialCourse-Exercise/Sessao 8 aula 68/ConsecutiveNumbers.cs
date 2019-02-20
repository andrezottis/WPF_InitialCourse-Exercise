using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class ConsecutiveNumbers
    {
        public static void VerifyuInputs()
        {
            Console.WriteLine("Please, enter with the numbers separeted by - :");
            string input = Console.ReadLine();

            var stringArray = input.Split('-');

            int[] intArray = new int [stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
                intArray [i] = int.Parse(stringArray[i]);
                
            }
            var min = intArray.Min();
            var max = intArray.Max();
            //bool isInSequence = intArray.SequenceEqual(Enumerable.Range(intArray.First(), intArray.Last()));
            bool isInSequence = intArray.SequenceEqual(Enumerable.Range(min, max));
            Console.WriteLine(isInSequence);


            Console.ReadLine();
        }
    }
}
