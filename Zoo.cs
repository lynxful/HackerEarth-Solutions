using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word:");
            string word = Console.ReadLine();
            Console.Clear();
            if (similarity(word) == true) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }

        public static bool similarity(string s)
        {
            int x = 0;
            int y = 0;

            for(int i = 0; i < s.Length;i++)
            {
                string character = s.Substring(i,1);

                switch (character)
                {
                    case "z":
                        x++;
                        break;
                    case "o":
                        y++;
                        break;
                }
            }

            if (x * 2 == y) return true; 
            else return false;
             
        }
    }
}