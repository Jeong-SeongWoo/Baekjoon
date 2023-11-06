using System;
using System.Text;

namespace Prob9506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true) 
            {
                int num = int.Parse(Console.ReadLine());
                int calc = 0;
                string answer = "";

                if (num == -1)
                    break;

                if (num % 10 == 6 || num % 10 == 8)
                {
                    answer = "";
                    for (int i = 1; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            calc += i;
                            answer = answer + i;
                            if (calc != num)
                                answer = answer + " + ";
                            else
                                continue;
                        }
                    }
                    if (calc == num)
                        Console.WriteLine(num + " = " + answer);
                    else
                        Console.WriteLine(num + " is NOT perfect.");
                }
                else
                    Console.WriteLine(num + " is NOT perfect.");
            }
        }
    }
}
