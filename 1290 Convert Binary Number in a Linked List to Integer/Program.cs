using System;

namespace _1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    //  Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        int reverse = 0;
        public int GetDecimalValue(ListNode head)
        {
            if (head.next == null)
            {
                return convertBinaryToDecimal(head.val);
            }
            return GetDecimalValue(head.next) + convertBinaryToDecimal(head.val);
        }

        public int convertBinaryToDecimal(int val)
        {
            if (val == 0)
            {
                reverse++;
                return 0;
            }
            return val * (int)Math.Pow(2, reverse++);
        }
    }
}
