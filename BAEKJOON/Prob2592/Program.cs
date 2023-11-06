using System;

namespace Prob2592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int sum = 0, cnt = 0, maxcnt = int.MinValue;
            int answer = 0;

            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                sum += nums[i];
            }

            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    cnt++;
                    if (cnt == nums.Length - 1)
                        answer = nums[i];
                }

                else
                {
                    if (cnt > maxcnt)
                    {
                        maxcnt = cnt;
                        answer = nums[i - 1];
                    }
                    cnt = 0;
                }
            }
            Console.WriteLine(sum / 10);
            Console.WriteLine(answer);
        }
    }
}
