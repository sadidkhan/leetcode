using System;

namespace _633._Sum_of_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Solution();
            var b = a.JudgeSquareSum(32);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool JudgeSquareSum(int c)
        {
            double mod = Math.Sqrt(c);
            if (mod % 1 == 0)
            {
                return true;
            }
            long low = 0;
            long high = (int) Math.Ceiling(mod);
            
            while (high >= low)
            {
                long mid = (high + low) / 2;
                long first = mid * mid;
                if (first > c)
                {
                    high = mid - 1;
                }
                else if (first < c)
                {
                    long difference = c - first;
                    double s = Math.Sqrt(difference);
                    if (s % 1 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        low = mid + 1;
                    }

                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
