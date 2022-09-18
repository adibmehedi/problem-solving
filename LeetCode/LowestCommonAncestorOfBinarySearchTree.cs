using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LowestCommonAncestorOfBinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            bool isLoop = true;

            while (isLoop)
            {
                if (p.val < root.val && q.val < root.val)
                {
                    root = root.left;
                } else
                if (p.val > root.val && q.val > root.val) {
                    root = root.right;
                }
                else {
                    isLoop = false;
                }
            }

            return root;


            //if (root == null) { return null; }

            //if (p.val < root.val && q.val < root.val)
            //{
            //    LowestCommonAncestor(p.left, p, q);
            //} else

            //if (p.val > root.val && q.val > root.val)
            //{
            //    LowestCommonAncestor(p.right, p, q);
            //} else

            //if (root.val == p.val || root.val == q.val) {
            //    Console.Write($"inside {root.val}");
            //    return root; 
            //}

            //return root;
        }
    }
}
