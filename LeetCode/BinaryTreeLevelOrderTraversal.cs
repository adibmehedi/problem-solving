using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BinaryTreeLevelOrderTraversal
    {

        public IList<IList<int>> Travarse(TreeNode root, IList<IList<int>> list, int level)
        {
            if (root == null) return list;
            //Console.WriteLine($"{level} {root.val} {list.Count}");

            if (list.Count == level) list.Add(new List<int>());
            list[level].Add(root.val);

            this.Travarse(root.left, list, level + 1);
            this.Travarse(root.right, list, level + 1);

            return list;
        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            return this.Travarse(root, list, 0);
        }
    }
}
