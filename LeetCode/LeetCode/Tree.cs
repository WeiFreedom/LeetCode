using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class Tree
    {
        /// <summary>
        /// 面试题 04.02. 最小高度树
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public TreeNode SortedArrayToBST(int[] nums)
        {
            int count = nums.Length;
            if (count == 0) return null;
            if (count == 1) return new TreeNode(nums[0]);
            int left = count / 2;//2 1
            TreeNode node = new TreeNode(nums[left]);
            int[] leftArray = nums.Take(left).ToArray();
            int[] rightArray = nums.Skip(left + 1).Take(count - left - 1).ToArray();
            node.left = SortedArrayToBST(leftArray);
            node.right = SortedArrayToBST(rightArray);
            return node;
        }
        /// <summary>
        /// 面试题55 - I. 二叉树的深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int leftLength = MaxDepth(root.left) + 1;
            int rightLength = MaxDepth(root.right) + 1;
            if (leftLength > rightLength) return leftLength;
            return rightLength;
        }

        /// <summary>
        /// 94. 二叉树的中序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;


            IList<int> left = InorderTraversal(root.left);
            if (left.Count > 0)
            {
                foreach (int item in left)
                {
                    result.Add(item);
                }
            }
            result.Add(root.val);

            IList<int> right = InorderTraversal(root.right);
            if (right.Count > 0)
            {
                foreach (int item in right)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// 144. 二叉树的前序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            result.Add(root.val);

            IList<int> left = PreorderTraversal(root.left);
            if (left.Count > 0)
            {
                foreach (int item in left)
                {
                    result.Add(item);
                }
            }
            IList<int> right = PreorderTraversal(root.right);
            if (right.Count > 0)
            {
                foreach (int item in right)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        /// <summary>
        /// 145. 二叉树的后序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;


            IList<int> left = PostorderTraversal(root.left);
            if (left.Count > 0)
            {
                foreach (int item in left)
                {
                    result.Add(item);
                }
            }
            IList<int> right = PostorderTraversal(root.right);
            if (right.Count > 0)
            {
                foreach (int item in right)
                {
                    result.Add(item);
                }
            }

            result.Add(root.val);
            return result;
        }
    }
}
