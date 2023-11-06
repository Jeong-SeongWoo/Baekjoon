using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] board = new string[input[0]];

            for(int i=0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine();
            }

            int min = int.MaxValue;

            for (int i=0; i <= input[0] - 8; i++)
            {
                for (int j = 0; j <= input[1] - 8; j++)
                {
                    int wcnt = 0;
                    int bcnt = 0;
                    for(int k = i; k < i + 8; k++)
                    {
                        for(int l = j; l < j + 8; l++)
                        {
                            if ((k + l) % 2 == 0)
                            {
                                if (board[k][l] != 'W')
                                    wcnt++;
                                if (board[k][l] != 'B')
                                    bcnt++;
                            }
                            else
                            {
                                if (board[k][l] != 'B')
                                    wcnt++;
                                if (board[k][l] != 'W')
                                    bcnt++;
                            }
                        }
                    }
                    min = Math.Min(min, Math.Min(wcnt, bcnt));
                }
            }
            Console.WriteLine(min);
        }
    }
}