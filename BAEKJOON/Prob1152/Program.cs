using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split(' ');
            int cnt = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                bool check = String.IsNullOrEmpty(sentence[i]);
                if (check == true)
                {
                    cnt++;
                }
            }
            Console.WriteLine(sentence.Length-cnt);
        }
    }
}
