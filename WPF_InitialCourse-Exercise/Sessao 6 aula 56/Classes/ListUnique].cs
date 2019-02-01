using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class ListUnique_
    {
        public static void UniqueNumbers()
        {
            Console.WriteLine("Enter the a number or Quit:");
            List<int> numbers = new List<int>();

            var check = Console.ReadLine();
            do
            {
                if (check !="Quit")
                {
                    numbers.Add(int.Parse(check));
                    Console.WriteLine("Enter the a number or Quit:");
                    check = Console.ReadLine();
                }
                else
                {
                    break;
                }

            } while (check !="Quit");

            var UniqueItemsList = numbers.Distinct().ToList();
            foreach (var item in UniqueItemsList)
            {
                Console.WriteLine(numbers[item]);
            }
            Console.Read();
        }
    }
}
