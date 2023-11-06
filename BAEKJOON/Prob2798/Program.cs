using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] cards = new int[int.Parse(input[0])];
            cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int min = int.MaxValue, answer = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                for(int j = i+1;  j < cards.Length; j++)
                {
                    for(int k = j+1;k<cards.Length; k++)
                    {
                        int sum = cards[i] + cards[j] + cards[k];
                        if (sum <= int.Parse(input[1]) && int.Parse(input[1]) - sum < min)
                        {
                            answer = cards[i] + cards[j] + cards[k];
                            min = int.Parse(input[1]) - (cards[i] + cards[j] + cards[k]);
                        }
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
