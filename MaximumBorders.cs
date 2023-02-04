using System;
using System.Linq;

namespace Application{

    internal class Program{

        static void Main(string[] args){
            int t = Convert.ToInt32(Console.ReadLine());
            while(t > 0){
                testcases();
                t--;
            }
        }

        static void testcases(){
            int n, m;
            getInt(out n, out m);
            
            string line = string.Empty;
            int count = 0;
            char[,] c = new char[n,m];
            
            for(int i = 0; i < n; i++){
                line = Console.ReadLine();
                for(int j = 0; j < m; j++)
                    c[i,j] = line[j]; 
            }

            int[] blackcell = new int[n];

            for(int i = 0; i < n; i++){
                count = 0;
                for(int j = 0; j < m; j++){
                    if(c[i,j].Equals('#'))
                    count++;    
                } 
                blackcell[i] = count;
            }
            Console.WriteLine(blackcell.Max());
        }

        static void getInt(out int n, out int m){
            string[] x = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(x[0]);
            m = Convert.ToInt32(x[1]);
        }
    }
}
