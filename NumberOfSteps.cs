using System;
using System.Linq;

namespace Application{

    internal class Program{

        static void Main(string[] args){
            Calculation();
        }

        static void Calculation(){
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int totalSteps = 0;
            bool isConverted = false;

            while(a.Min() > -1){
                int MinValue = a.Min();
                int counter = 0;
                do{
                    if(a[counter] != MinValue){
                        a[counter] -= b[counter];
                        totalSteps++;
                    }
                    counter++;
                } while(counter < n);

                if(a.Distinct().Count() == 1){
                    Console.WriteLine(totalSteps);
                    isConverted = true;
                    break;
                }
            }

            if(!isConverted)
            Console.WriteLine(-1);
        }
    }
}
