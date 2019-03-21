using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class PascalCase
    {
        public static void TransformToPascal()
        {
            Console.WriteLine("Please, enter a string:" );
            var input = Console.ReadLine();

            var resultBuilder = new StringBuilder();

            foreach (char c in input)
            {
                // Replace anything, but letters and digits, with space
                if (!Char.IsLetterOrDigit(c))
                {
                    resultBuilder.Append(" ");
                }
                else
                {
                    resultBuilder.Append(c);
                }
            }

            string result = resultBuilder.ToString();

            // Make result string all lowercase, because ToTitleCase does not change all uppercase correctly
            result = result.ToLower();

            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            //References of this method here: https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.textinfo.totitlecase?view=netframework-4.7.2
            //Very fucking smart
            result = myTI.ToTitleCase(result).Replace(" ", String.Empty);

            Console.WriteLine("The Pascal Case text is: " + result);
            Console.Read();

        }
    }
}
