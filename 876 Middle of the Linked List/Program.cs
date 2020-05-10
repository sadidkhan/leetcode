using System;

namespace _876_Middle_of_the_Linked_List
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
        public ListNode MiddleNode(ListNode head)
        {
            ListNode mid = head;
            ListNode last = head;
            while (last != null && last.next != null)
            {
                mid = mid.next;
                last = last.next.next;
            }

            return mid;
        }
    }
}
