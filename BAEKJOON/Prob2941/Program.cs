using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = Console.ReadLine();
            int cnt = 0;

            for(int i = 0; i < alphabet.Length; i++)
            {
                if (i == alphabet.Length - 1)
                {
                    cnt++;
                    break;
                }
                switch(alphabet[i])
                {
                    case 'c':
                        if (alphabet[i + 1] == '=' || alphabet[i + 1] == '-')
                        {
                            cnt++;
                            i++;
                        }
                        else
                            cnt++;
                        continue;

                    case 'd':
                        if (alphabet[i + 1] == 'z')
                        {
                            if (alphabet.Length < 3)
                            {
                                cnt++;
                                continue;
                            }
                            else
                            {
                                if (alphabet[i + 2] == '=')
                                {
                                    cnt++;
                                    i += 2;
                                }
                                else
                                {
                                    cnt++;
                                }
                            }
                        }
                        else if (alphabet[i + 1] == '-')
                        {
                            cnt++;
                            i++;
                        }
                        else
                            cnt++;
                        continue;
                    case 'l':
                    case 'n':
                        if (alphabet[i + 1] == 'j')
                        {
                            cnt++;
                            i++;
                        }
                        else
                            cnt++;
                        continue;
                    case 's':
                    case 'z':
                        if (alphabet[i + 1] == '=')
                        {
                            cnt++;
                            i++;
                        }
                        else
                            cnt++;
                        continue;
                    default:
                        cnt++;
                        continue;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
