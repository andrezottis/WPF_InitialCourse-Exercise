using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class AskFiveNumbers
    {
        public static void FiveNumbers()
        {

            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                var check = true;
                Console.WriteLine("Enter the {0} number:", (i + 1));
                var input = int.Parse(Console.ReadLine());
                do
                {
                    check = Array.Exists(numbers, element => element == input);
                    if(check is true)
                    {
                        Console.WriteLine("Enter UNIQUE number at position {0}:", (i + 1));
                        input = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        numbers[i] = input;
                    }

                } while (check is true);
            }
            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
