using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] realtime = Console.ReadLine().Split();
            string loadtime = Console.ReadLine();

            int hour = int.Parse(realtime[0]);
            int minute = int.Parse(realtime[1]) + int.Parse(loadtime);

            if(minute < 60)
                Console.WriteLine(hour + " " +  minute);

            else
            {
                hour += minute / 60;
                
                if( hour >= 24)
                    hour %= 24;
               
                minute = minute % 60;
                Console.WriteLine(hour + " " + minute);
            }
        }
    }
}
