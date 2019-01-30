using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class NameReverse
    {
        public static void reverseName()
        {
            Console.WriteLine("Type your name");
            string nomeDigitado = Console.ReadLine();
            int size = nomeDigitado.Length;
            char[] nomeOriginal = nomeDigitado.ToCharArray();
            
            Array.Reverse(nomeOriginal);
            char[] sortedNome = new char[size];
            Array.Copy(nomeOriginal,sortedNome,size);
            Array.Sort(sortedNome);

            Console.WriteLine("The name reversed is: ");
            foreach (var n in nomeOriginal)
            {
                Console.Write(n);
            }
            Console.Read();

        }
    }
}
