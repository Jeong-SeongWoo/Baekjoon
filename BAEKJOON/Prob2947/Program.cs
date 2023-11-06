using System;

namespace Prob2231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int range;
            if (n >= 10)
                range = ((input.Length - 1) * 9) + (int.Parse(input[0].ToString()) - 1);
            else
                range = n;
            int answer = 0;

            for (int i = n - range; i < n; i++)
            {
                int sum = i;
                input = i.ToString();
                for (int j = 0; j < input.Length; j++)
                    sum += int.Parse(input[j].ToString());

                if (sum == n)
                {
                    answer = i;
                    break;
                }

            }
            Console.WriteLine(answer);
        }
    }
}
