using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToUpper();
            int[] cnt = new int[26];
            int max = -999;
            int location = 0;
            int count = 0;

            for(int i = 0; i < word.Length; i++)
                cnt[Convert.ToInt32(word[i]) - 65]++;
            
            for (int j = 0;  j < cnt.Length; j++)
            {
                if(max < cnt[j])
                {
                    count = 0;
                    max = cnt[j];
                    location = j;
                }
                
                else if (cnt[j] != 0 && max == cnt[j])
                    count++;
                
                if (j == cnt.Length - 1)
                {
                    if (count > 0)
                        Console.WriteLine("?");
                    else 
                        Console.WriteLine(Convert.ToChar(location + 65));
                }
            }
        }
    }
}
