using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class GuessTheNumber
    {
        public static void Guess()
        {
            var random = new Random();
            int guessnumber = random.Next(11);

            Console.WriteLine("Guess what number is?");

            for (int i = 0; i < 4; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == guessnumber)
                {
                    Console.WriteLine("You are fucking awesome! The number is {0}!", input);
                    Console.Read();
                    break;
                }
                else
                {
                    Console.WriteLine("try again!");
                }
            }
            Console.WriteLine("It seems that you couldnt guess the number, so there is: {0}",guessnumber);
            Console.Read();

        }
    }
}
