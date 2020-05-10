using System;

namespace Best_Time_to_Buy_and_Sell_Stock_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            s.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            s.MaxProfit(new int[] { 1, 2, 3, 4, 5 });
            s.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int sum = 0;
            int start = 0;
            int end = 0;
            for (var i = 0; i < prices.Length; i++)
            {
                var current = prices[i];
                if (i == 0)
                {
                    start = current;
                    continue;
                }
                if (current < start)
                {
                    start = current;
                    end = 0;
                }
                else if (current > start)
                {
                    end = current;
                    sum += (end - start);
                    start = current;
                }
            }

            return sum;
        }
    }
}
