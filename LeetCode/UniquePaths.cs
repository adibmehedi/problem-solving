using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniquePathsSolution
    {
        int CalculateCost(int m, int n, int row, int column, int[,]cache)
        {
            if (row == m - 1 && column == n - 1) { return 1; }
            if (row >= m || column >= n) { return 0; }

            if (cache[row, column] == -1)
            {
                cache[row, column] = CalculateCost(m, n, row + 1, column, cache) + CalculateCost(m, n, row, column + 1, cache);
            }
            return cache[row, column];
        }

        public int UniquePaths(int m, int n)
        {
            int[,] cache = new int[m, n];
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    cache[i,j] = -1;
                }
            }
            return CalculateCost(m, n, 0, 0, cache);
        }
    }
}
