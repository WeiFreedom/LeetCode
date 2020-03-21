using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class LinkedList
    {
        /// <summary>
        /// 将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
        /// 示例：
        /// 输入：1->2->4, 1->3->4
        /// 输出：1->1->2->3->4->4
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            /**
             * 递归
             * 时间复杂度:
             *  O(m+n) : l1和l2都只会遍历一次,最坏的情况下,比如 1->3, 2->4,
             *  1-2 对比
             *  2-3 对比
             *  3-4 对比
             *  4-退出
             *  两个链表每个节点都需要遍历一次
             * 空间复杂度:
             *  O(m+n) : 递归调用相当于堆栈,最坏的情况下,比如1->3,2->4
             *  要得到1->2->3->4 就先要得到 2->3->4 就先要得到 3->4 就先要得到 4
             */
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val > l2.val)
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
            else
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
        }

        /// <summary>
        /// 给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。
        /// 示例：
        /// 给定一个链表: 1->2->3->4->5, 和 n = 2.
        /// 当删除了倒数第二个节点后，链表变为 1->2->3->5.
        /// 说明：
        /// 给定的 n保证是有效的。
        /// 进阶：
        /// 你能尝试使用一趟扫描实现吗？
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || (head.next == null && n >= 1)) return null;
            int count = 0;
            ListNode node = head;
            ListNode locaion = head;
            while (node.next != null)
            {
                count++;
                if (count > n)
                    locaion = locaion.next;
                node = node.next;
            }
            if (count + 1 < n) return head;
            if (count + 1 == n) return head.next;
            locaion.next = locaion.next.next;
            return head;
        }
    }
}
