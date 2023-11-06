using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] now = Console.ReadLine().Split();
            int hour = int.Parse(now[0]);
            int minute = int.Parse(now[1]);
            int second = int.Parse(now[2]);

            int expectedtime = int.Parse(Console.ReadLine());

            int expectedhour = expectedtime / 3600;
            int expectedminute = expectedtime % 3600 / 60;
            int expectedsecond = expectedtime % 3600 % 60;

            expectedhour += hour;
            expectedminute += minute;
            expectedsecond += second;

            if(expectedsecond >= 60)
            {
                expectedminute += expectedsecond / 60;
                expectedsecond %= 60;
            }

            if(expectedminute >= 60)
            {
                expectedhour += expectedminute / 60;
                expectedminute %= 60;
            }

            if(expectedhour >= 24)
            {
                expectedhour %= 24;
            }

            Console.WriteLine("{0} {1} {2}", expectedhour, expectedminute, expectedsecond);
        }
    }
}
