using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NAryTreePreorderTraversal
    {
        public IList<int> Travarse(Node root, IList<int> list)
        {
            if (root == null) { return list; }

            list.Add(root.val);
            int childCount = root.children.Count;
            if (childCount > 0)
            {
                int counter = 0;
                while (counter < childCount)
                { 
                    this.Travarse(root.children[counter], list);
                    counter++;
                }
            }
            return list;
        }
        public IList<int> Preorder(Node root)
        {
            return this.Travarse(root, new List<int>());
        }
    }
}
