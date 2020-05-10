using System;

namespace _704_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            var a = s.Search(new int[6] { -1, 0, 3, 5, 9, 12 }, 9);
            var b = s.Search(new int[6] { -1, 0, 3, 5, 9, 12 }, 2);
            var c = s.Search(new int[6] { -1, 0, 3, 5, 9, 12 }, -1);
            var d = s.Search(new int[6] { -1, 0, 3, 5, 9, 12 }, 12);

            var e = s.Search(new int[6] { -1, 0, 3, 5, 9, 12 }, 13);
            var f = s.Search(new int[3] {0, 1, 2}, 0);
            var g = s.Search(new int[1] { 1 }, -1);
            var g1 = s.Search(new int[2] { 2,5 }, 0);
            Console.ReadKey();
        }

    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            return BinarySearch(nums, low, high, target);
        }

        public int BinarySearch(int[] nums, int low, int high, int target)
        {
            int mid = (high + low) / 2;

            if (low >= high && nums[low] != target)
            {
                return -1;
            }

            if (target == nums[mid])
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                low = mid + 1;
            }
            else if (target < nums[mid])
            {
                high = mid - 1;
            }
            return BinarySearch(nums, low, high, target);
        }
    }
}
