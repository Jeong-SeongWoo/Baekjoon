using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prob10757
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        string[] input = Console.ReadLine().Split();

                        int max = input[0].Length >= input[1].Length ? input[0].Length : input[1].Length;

                        if (input[0].Length > input[1].Length)
                            input[1] = input[1].PadLeft(max, '0');
                        else if (input[0].Length < input[1].Length)
                            input[0] = input[0].PadLeft(max, '0');

                        char[] a = new char[max];
                        char[] b = new char[max];

                        a = input[0].Reverse().ToArray();
                        b = input[1].Reverse().ToArray();
                        int[] n = new int[max + 1];

                        for(int i = 0; i < max; i++)
                        {
                            n[i] += int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());

                            if (n[i] > 9)
                            {
                                n[i] %= 10;
                                n[i + 1]++;
                            }
                        }

                        for (int i = max; i>=0; i--)
                        {
                            if (i == max)
                            {
                                if (n[i] == 0)
                                    continue;
                                else
                                {
                                    Console.Write(n[i]);
                                    continue;
                                }
                            }
                            else
                                Console.Write(n[i]);
                        }*/

            string[] input = Console.ReadLine().Split();
            Console.WriteLine(BigInteger.Parse(input[0]) + BigInteger.Parse(input[1]));
        }
        
    }
}
