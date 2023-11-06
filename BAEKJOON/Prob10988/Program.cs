using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10988
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - (i + 1)])
                    {
                        Console.WriteLine("0");
                        break;
                    }
                    if (i == word.Length / 2 - 1)
                    {
                        Console.WriteLine("1");
                    }

                }
            }
        }
    }
}
