using System;

namespace Application{

    internal class Program{

        static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int count = 0;

            do{
                for(int i = 0; i < 3; i++){
                s = swap(s);  
                count++;  
                }
            }while(!(s.Equals(t)));

            Console.WriteLine(count);
        }

        static string swap(string s){
            s += s[0];
            s = s.Remove(0,1);
            return s;
        }
    }
}
