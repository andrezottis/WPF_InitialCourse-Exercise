using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class listcomma
    {
        public static void GetValues()
        {
            Console.WriteLine("please, type at least 5 numbers splited by comma (,): ");
            List<int> numberlist = new List<int>();
            string numbers = Console.ReadLine();
            numberlist = numbers.Split(',').Select(int.Parse).ToList();
            if (numberlist.Count < 5)
            {
                Console.WriteLine("Please, inser at least 5 numbers: ");
                numbers = Console.ReadLine();
                numberlist = numbers.Split(',').Select(int.Parse).ToList();
            }
            if (numberlist.Count < 5)
            {
                GetValues();
            }
            int a = numberlist.Min();
            int b = numberlist.Max();
            int c = numberlist.Max();

            foreach (var item in numberlist)
            {
                if (b > item && item != a)
                {
                    b = item;
                }
            }
            foreach (var item in numberlist)
            {

                if (c > item && c > b && item != a && item !=b)
                {
                    c = item;
                }
                
            }

            Console.WriteLine("1 - {0}", a);
            Console.WriteLine("2 - {0}", b);
            Console.WriteLine("3 - {0}", c);
            Console.Read();


        }
    }
}
