using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_InitialCourse_Exercise
{
    class FacebookLike
    {
        public static void contarLikes()
        {
            List<string> FriendsName = new List<string>();
            var cond = true;
            do
            {
                Console.WriteLine("Digite um nome:" );
                String input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    cond = false;
                }
                else
                {

                FriendsName.Add(input);
                }

            } while (cond == true);
            int size = FriendsName.Count;
            if (size == 1 )
            {
                Console.WriteLine("{0} likes your post.", FriendsName[0]);
            }
            else if(size == 2)
            {
                Console.WriteLine("{0}, {1} likes your post.", FriendsName[0],FriendsName[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1} and other {2} likes your post.", FriendsName[0], FriendsName[1], (size-2));
            }
            Console.Read();
        }
    }
}
