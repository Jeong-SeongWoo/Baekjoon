using System;
using System.Linq;

namespace Prob1316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt  = int.Parse(Console.ReadLine());
            string[] words = new string[cnt];
            bool[] check = new bool[26];
            int answer = 0;

            for (int i=0; i<cnt; i++)
                words[i] = Console.ReadLine();

            for(int i = 0; i < words.Length; i++)
            {
                int count = 0;
                check = Enumerable.Repeat(false, 26).ToArray();
                check[(int)words[i][0] - 97] = true;
                for(int j = 1; j < words[i].Length; j++)
                {
                    if (words[i][j] == words[i][j - 1])
                    {
                        count++;
                        continue;
                    }
                    else if (words[i][j] != words[i][j - 1] && check[(int)words[i][j] - 97] == true)
                        break;
                    
                    else
                    {
                        check[(int)words[i][j] - 97] = true;
                        count++;
                    }
                }
                if(count == words[i].Length - 1)
                    answer++;
            }
            Console.WriteLine(answer);
        }
    }
}
