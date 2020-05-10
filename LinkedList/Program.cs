using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

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

    public class LinkedList {
        private ListNode root = null;
        private ListNode lastNode = null;

        public ListNode() {

        }

        public void insertLast(int val) {
            var n = new ListNode(val);
            if(root == null){
                root = n;
                lastNode = root.next;
            }
            else {
                lastNode = n;
                la

            }
        }

        public void insertFirst(int val) {
            var n = new ListNode(val);
            if(root == null) {
                root = n;
            }
            else {
                var prev = root;
                root = n;
                root.next = prev;
            }
        }
    }
}
