using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

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
    class MergeTwoSortedLists
    {
        public static ListNode MergeTwoList(ListNode list1, ListNode list2)
        {
            if (list1 == null) { return list2; }
            if (list2 == null) { return list1; }

            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoList(list1.next, list2);
                return list1;
            }
            else {
                list2.next = MergeTwoList(list1, list2.next);
                return list2;
            }

        }
    }

}
