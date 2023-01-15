namespace CountInString
{
    internal class CountInString
    {
        static public void Main()
        {
            String line;
            line = Console.ReadLine();
            int T = Convert.ToInt32(line);

            for (int t_i = 0; t_i < T; t_i++)
            {
                String S;
                S = Console.ReadLine();
                line = Console.ReadLine();
                char k = Convert.ToChar(line);

                int out_ = solve(S, k);
                Console.Out.WriteLine(out_);

            }
        }

        static int solve(String S, char k)
        {
            int result = 0;
            foreach (char c in S.ToCharArray()) if(c == k) result++;
            return result;

        }
    }
}