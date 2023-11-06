using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob16199
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] birth  = Console.ReadLine().Split();
            string[] today = Console.ReadLine().Split();
            int age=0, korage=1, yearage=0;

            if (birth[0] != today[0])
            {
                korage = int.Parse(today[0]) - int.Parse(birth[0]) + 1;
                yearage = int.Parse(today[0]) - int.Parse(birth[0]);

                if (int.Parse(birth[1]) > int.Parse(today[1]))
                    age = korage - 2;
                else if (int.Parse(birth[1]) < int.Parse(today[1]))
                    age = korage - 1;
                else
                {
                    if (int.Parse(birth[2]) > int.Parse(today[2]))
                        age = korage - 2;
                    else if (int.Parse(birth[2]) <= int.Parse(today[2]))
                        age = korage - 1;
                }
            }
            Console.WriteLine(age);
            Console.WriteLine(korage);
            Console.Write(yearage);
        }
    }
}
