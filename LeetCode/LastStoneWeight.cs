using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LastStoneWeightSolution
    {
        public int LastStoneWeight(int[] stones)
        {

            var queue = new PriorityQueue<int, int>();

            foreach (int stone in stones)
            {
                queue.Enqueue(stone, -stone);
            }

            while (queue.Count > 1)
            {
                int stone1 = queue.Dequeue();
                int stone2 = queue.Dequeue();
                if (stone1 != stone2) 
                {
                    int diff = Math.Abs(stone1 - stone2);
                    queue.Enqueue(diff, -diff);
                }
            }

            return queue.Count > 0 ? queue.Dequeue() : 0;

        }
    }
}
