using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FloodFillSolution
    {
        public void Fillup(int[][] image, int sr, int sc, int newColor, int startingColor) 
        {

            int maxRow = image.Length, maxCol = image[0].Length;

            if (sr < 0 || sr >= maxRow || sc < 0 || sc >= maxCol || image[sr][sc] != startingColor || image[sr][sc] == newColor) 
            {
                return; 
            }

            image[sr][sc] = newColor; 

            Fillup(image, sr + 1, sc, newColor, startingColor);
            Fillup(image, sr - 1, sc, newColor, startingColor);
            Fillup(image, sr, sc + 1, newColor, startingColor);
            Fillup(image, sr, sc - 1, newColor, startingColor);
        }
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int currentColor = image[sr][sc];

            if (currentColor == color) { return image; }

            Fillup(image, sr, sc, color, currentColor);
            return image;
        }

    }
}
