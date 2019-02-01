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

                int a = numberlist.Min();
                int b = numberlist.Max();
                int c =numberlist.Count();
                
            foreach (var item in numberlist)
                {
                    if (item == a)
                {
                    break;
                }
                else if ( c > item)
                    {
                    c = item;
                    } else if (b > c)
                    {
                        b = c;
                    }
                    else if (a > b)
                    {
                        a = b;
                    }
                }

            Console.WriteLine("1 - {0}" ,a);
            Console.WriteLine("2 - {0}", b);
            Console.WriteLine("3 - {0}", c);
            Console.Read();


        }
    }
}
