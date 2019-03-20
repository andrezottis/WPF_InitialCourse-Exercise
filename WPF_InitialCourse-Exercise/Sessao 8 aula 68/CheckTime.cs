using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class CheckTime
    {
        public static void verifyTimeInput()
        {
            Console.WriteLine("Please, enter a 24-hour time between 00:00 and 23:59 :");
            var input = Console.ReadLine();

            try
            {
                var timeImput = DateTime.Parse(input);
                var hourMinute = timeImput.ToString("HH:mm");
                Console.WriteLine("Valid time: " + hourMinute);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time");
            }
            Console.Read();


        }
    }
}
