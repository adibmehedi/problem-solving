using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head!=null)
            {
                ListNode current = head;
                head = current.next;
                current.next = prev;
                prev = current;
            }
            return prev;
        }
    }
}
