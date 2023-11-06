using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Prob1330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);

            if (A != B)
            {
                if( A > B )
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("<");
                }
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
