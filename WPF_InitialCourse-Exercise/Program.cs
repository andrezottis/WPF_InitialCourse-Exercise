﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("type the number to the exercise: \n" +
            //    "1. Count divisibles \n" +
            //    "2. Infinite SUM \n" +
            //    "3. Factoration \n" +
            //    "4. Guess the Number \n" +
            //    "5. The higher number");

            //>>>>Sesao 6 aula 56
            //Console.WriteLine("type the number to the exercise: \n" +
            //    "1. Reverse name \n" +
            //    "2. Facebook Like \n" +
            //    "3. Ask 5 numbers \n" +
            //    "4. List of Unique Numbers \n" +
            //    "5. The higher number");

            //>>>>Sessao 8 aula 68
            Console.WriteLine("type the number to the exercise: \n" +
                "1. Consecutive Numbers \n" +
                "2. Verify Duplicates \n" +
                "3. Check time input \n" +
                "4. Transform to PascalCase \n" +
                "5. Count the number of Vogels ");

            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                //>>>Sessao 5 aula 49
                //case 1:
                //    Divisible.CheckDivisible();
                //    break;
                //case 2:
                //    InfiniteSUM.AskSum();
                //    break;
                //case 3:
                //    Factorial.NumberFactorial();
                //    break;
                //case 4:
                //    GuessTheNumber.Guess();
                //    break;
                //case 5:
                //    TheHigher.GetHigher();

                //    break;

                //>>>>Sesao 6 aula 56
                case 1:
                    ConsecutiveNumbers.VerifyuInputs(); 
                    break;

                case 2:
                    VerifyDuplicated.verifyDuplicated();
                    break;

                case 3:
                    CheckTime.verifyTimeInput();
                    break;

                case 4:
                    PascalCase.TransformToPascal();
                    break;
                case 5:
                    CountVowels.countAllVowels();
                    break;
                default:
                    break;
            }
        }
    }
}
