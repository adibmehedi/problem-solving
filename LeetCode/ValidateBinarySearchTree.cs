using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidateBinarySearchTree
    {
        public bool Validate(TreeNode node, long min, long max)
        {
            if (node == null) { return true; }

            if (node.val >= max || node.val <= min) { return false; }

            return Validate(node.left, min, node.val) && Validate(node.right, node.val, max); ;
        }
        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, long.MinValue, long.MaxValue);
        }
    }
}
