using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0];
            
            if (n == 1)
            {
                for(int i = 0; i < input.Length; i++)
                {
                    if (input[i] != i + 1)
                    {
                        Console.WriteLine("mixed");
                        break;
                    }
                    if( i == input.Length - 1)
                        Console.WriteLine("ascending");
                }
            }
            else if ( n == 8 )
            {
                for (int i = 0; i <input.Length; i++)
                {
                    if (input[i] != n - i)
                    {
                        Console.WriteLine("mixed");
                        break;
                    }
                    if( i == input.Length - 1)
                        Console.WriteLine("descending");
                }
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}
