using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2869
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rise = int.Parse(input[0]);
            int fall = int.Parse(input[1]);
            int tot = int.Parse(input[2]);
            int answer;

            if (rise >= tot) //rise보다 tot가 같거나 작으면 계산할 필요 없이 하루만에 올라갈수 있음
                answer = 1;
            else // tot에 도착할때 도착할 수 있는 가지의 수는 2가지 -> tot에서 rise를 뺀 값을 rise - fall 값으로 나눌 시 나머지가 0이면 다음 날 낮에 올라가는 것 만으르 끝낼수 있고,
            {    // 나머지가 0이 아닌 값이면 한번더 rise - fall 만큼 올라갈 수 있으므로 이틀의 시간이 더 걸림.
                if ((tot - rise) % (rise - fall) == 0)  
                    answer = (tot - rise) / (rise - fall) + 1;
                else
                    answer = (tot - rise) / (rise - fall) + 2;
            }

            Console.WriteLine(answer);
        }
    }
}
