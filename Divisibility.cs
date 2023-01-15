namespace Divisibility
{
    internal class Divisibility
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            
            string value,output = "";
            int N = random.Next(1, 15);
            int[] arr = new int[N - 1];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1,100);               
                value = Convert.ToString(arr[i]);
                output = output + value.Last();
            }

            if ((Convert.ToInt32(output)%10) == 0 ) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}