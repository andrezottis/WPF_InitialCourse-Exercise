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
            //Console.WriteLine("Please, enter with the numbers separeted by - :");
            //string input = Console.ReadLine();

            //var stringArray = input.Split('-');

            //int[] intArray = new int [stringArray.Length];
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.WriteLine(stringArray[i]);
            //    intArray [i] = int.Parse(stringArray[i]);

            //}
            //var min = intArray.Min();
            //var max = intArray.Max();
            ////bool isInSequence = intArray.SequenceEqual(Enumerable.Range(intArray.First(), intArray.Last()));
            ////bool isInSequence = intArray.SequenceEqual(Enumerable.Range(min, max));
            //var condicao = true;
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    if (intArray[i] != intArray[i - 1] + 1)
            //    {
            //        condicao = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(condicao);


            //Professor solution:
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
