using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10809
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string word = Console.ReadLine();
            int j;
            
            for (int i = 0; i < 26; i++)
            {
                for (j = 0; j < word.Length; j++)
                {
                    int ascii = Convert.ToInt32('a') + i;
                    if (Convert.ToInt32(word[j]) == ascii) 
                    {
                        sb.Append(j + " ");
                        break;
                    }
                }
                if( j == word.Length)
                {
                    sb.Append("-1 ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
