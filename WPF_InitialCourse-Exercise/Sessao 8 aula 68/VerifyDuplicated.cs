using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class VerifyDuplicated
    {
        public static void verifyDuplicated()
        {
            Console.WriteLine("Please, enter a sequence of number separed by '-' exemple: 5-6-7-8-9, or type Enter to finish: ");

            string input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                var stringArray = input.Split('-');
                int[] intArray = new int[stringArray.Length];
                int lastValue = 0;
                Boolean duplicated = false;
                for (int i = 0; i < intArray.Length; i++)
                {
                    Console.WriteLine(stringArray[i]);
                    intArray [i] = int.Parse(stringArray[i]);
                    if (intArray[i] - lastValue == 0)
                    {
                        duplicated = true;
                    }
                    else
                        lastValue = intArray[i];
                }
                Console.WriteLine("\n Exist a value duplicated? " + duplicated);
            }
            else
                Console.WriteLine("Fechando...");
            Console.Read();

        }
    }
}
