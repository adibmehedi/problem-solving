using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumberOfIslands
    {
        void fill(char[][] grid, int i, int j)
        {
            int mLength = grid.Length;
            int nLength = grid[0].Length;
            if (i < 0 || i >= mLength || j < 0 || j >= nLength || grid[i][j] == '0') { return; }

            grid[i][j] = '0';

            fill(grid, i + 1, j);
            fill(grid, i - 1, j);
            fill(grid, i, j + 1);
            fill(grid, i, j - 1);
        }
        public int NumIslands(char[][] grid)
        {
            int mLength = grid.Length;
            int nLength = grid[0].Length;
            int islandCount = 0;

            for (int i = 0; i < mLength; i++)
            {
                for (int j = 0; j < nLength; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandCount++;
                        fill(grid, i, j);
                    }
                }
            }

            return islandCount;
        }

    }
}
