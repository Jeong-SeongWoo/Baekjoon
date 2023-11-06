using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dice = Console.ReadLine().Split();
            int a = int.Parse(dice[0]);
            int b = int.Parse(dice[1]);
            int c = int.Parse(dice[2]);

            if( a == b && a == c)
                Console.WriteLine(10000 + a * 1000);
            
            else if ( a == b || a == c || b == c)
            {
                if (b == c)
                    Console.WriteLine(1000 + b * 100);
                else
                    Console.WriteLine(1000 + a * 100);
            }
            
            else
            {
                if ( a > b && a > c)
                    Console.WriteLine( a * 100 );
                else if ( b > a && b > c)
                    Console.WriteLine( b * 100 );
                else
                    Console.WriteLine( c * 100 );
            }
        }
    }
}
