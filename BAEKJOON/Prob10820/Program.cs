using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10820
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int[] cnt = new int[] { 0, 0, 0, 0 };
                if (input == null)
                    break;

                for (int i = 0; i < input.Length; i++)
                {
                    int n = input[i];
                    if (n >= 65 && n <= 90)
                        cnt[1]++;
                    else if (n >= 97 && n <= 122)
                        cnt[0]++;
                    else if (input[i] == ' ')
                        cnt[3]++;
                    else
                        cnt[2]++;
                }

                for (int i = 0;i < cnt.Length;i++)
                    Console.Write(cnt[i] + " ");
                Console.WriteLine();
            } 
        }
    }
}
