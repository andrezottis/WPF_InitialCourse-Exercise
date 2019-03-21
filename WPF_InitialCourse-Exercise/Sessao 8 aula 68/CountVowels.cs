using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class CountVowels
    {
        public static void countAllVowels()
        {
            Console.WriteLine("Please, enter a sentence:");
            var sentence = Console.ReadLine();
            var count = 0;

            sentence = sentence.ToLower();

            foreach (var c in sentence)
            {
                if (c == 'a' || c=='e' || c=='i' || c=='o' || c=='u')
                {
                    count++;
                }

            }
            Console.WriteLine("To the word '{0}', we have a total of {1} vowels.", sentence,count);
            Console.Read();
            

        }
    }
}
