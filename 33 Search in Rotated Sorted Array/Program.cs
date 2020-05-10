using System;

namespace _33_Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            var a = s.Search(new int[3] { 5, 1, 3 }, 5);
            var b = s.Search(new int[8] { 4, 5, 6, 7, 8, 1, 2, 3 }, 8);
            var c = s.Search(new int[1] { 1 }, 2);
            var d = s.Search(new int[5] { 5,1,2,3,4 }, 4);
            var e = s.Search(new int[7] { 45, 71, 72, 0, 1, 21, 33 }, 33);
            var d1 = s.Search(new int[5] { 5, 1, 2, 3, 4 }, 1);
            var e1 = s.Search(new int[7] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            var f = s.Search(new int[3] { 3, 5 ,1 }, 3);
            var g = s.Search(new int[5] { 8, 9, 2, 3, 4 },9);
            //var g1 = s.Search(new int[2] { 2, 5 }, 0);
            Console.ReadKey();
        }

    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;

            while (high >= low)
            {
                mid = (high + low) / 2;
                if (target > nums[mid])
                {
                    if (target > nums[high] && nums[low] > nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else if (target < nums[mid])
                {
                    if (target < nums[low] && nums[mid] > nums[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }

                }
                else return mid;
            }
            return -1;
        }
    }
}
