using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2884
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wakeTime = Console.ReadLine().Split();
            int hour = int.Parse(wakeTime[0]);
            int minute = int.Parse(wakeTime[1]);

            if (minute >= 45)
            {
                Console.WriteLine(hour + " " +  (minute - 45));
            }
            else
            {
                minute = minute + 15;
                if (hour == 0)
                {
                    hour = 23;
                    Console.WriteLine(hour + " " +  minute);
                }
                else
                {
                    Console.WriteLine((hour -1) + " " + minute);
                }
            }
        }
    }
}
