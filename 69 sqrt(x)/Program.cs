using System;

namespace _69_sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var a = s.MySqrt(4);
            var a1 = s.MySqrt(8);
            var a2 = s.MySqrt(11);
            var a3 = s.MySqrt(2147395599);
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MySqrt(int x)
        {
            long low = 0;
            long high = x;
            while (high >= low)
            {
                long mid = (high + low) / 2;
                long sqr = mid * mid;

                if (sqr > x)
                {
                    high = mid - 1;
                }
                else if (sqr < x)
                {
                    low = mid + 1;
                }
                else
                {
                    return (int)mid;
                }

            }
            return (int)--low;
        }

        public int MySqrt1(int x)
        {
            int lo = 1; // covers base case #2: if x = 1 we will enter the loop to find exact sqrt immediately
            int hi = x /2 ; // covers base case #1: if x = 0 we will skip the loop and just return hi
            while (lo <= hi)
            {
                int m = (lo + hi) / 2;
                // we could check with m * m > x but that is susceptible to integer overflow
                if (m > x / m)
                {
                    hi = m - 1;
                }
                else if (m < x / m)
                {
                    lo = m + 1;
                }
                else
                {
                    // exact integer sqrt value found
                    return m;
                }
            }
            /*
             * exact integer sqrt wasn't found and our pointers crossed terminating the loop condition (hi < lo).
             * now hi pointer crossed our "imaginary" sqrt value one position to the left
             * while lo pointer crossed our "imaginary" sqrt value one position to the right
             * and we want the lower (rounded) value closest to the decimal sqrt, so we return hi in this case
             */
            return hi;
        }
    }
}
