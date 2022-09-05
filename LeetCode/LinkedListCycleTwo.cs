using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LinkedListCycleTwo
    {
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head, fast = head, entry = head;

            while (fast!= null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow) 
                {

                    while (entry != slow)
                    {
                        entry = entry.next;
                        slow = slow.next;
                    }
                    return entry;
                }
            }

            return null;
        }
    }
}
