using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }
}
