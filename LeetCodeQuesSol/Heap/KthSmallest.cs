using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Heap
{
    public static class KthSmallest
    {
        public static int KthSmallestInMatrix(int[][] matrix, int k)
        {
            # region NOT OPTIMAL
            //PriorityQueue<int, int> que = new();

            //for(int i=0; i<matrix.Length; i++)
            //{
            //    for(int j=0; j < matrix[i].Length; j++)
            //    {
            //        que.Enqueue(matrix[i][j], -matrix[i][j]);

            //        if(que.Count > k)
            //        {
            //            que.Dequeue();
            //        }
            //    }
            //}

            //return que.Dequeue();
            # endregion

            PriorityQueue<(int value, int row, int col), int> que = new();
            HashSet<(int, int)> visited = new();

            int iteration = 0;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int result = 0;

            que.Enqueue((matrix[0][0], 0, 0), matrix[0][0]);
            visited.Add((0, 0));

            while(iteration < k)
            {
                iteration++;

                (int val, int row, int col) = que.Dequeue();

                result = val;

                if(row+1 < rows && !visited.Contains((row +1, col)))
                {
                    que.Enqueue((matrix[row+1][col], row + 1, col), matrix[row + 1][col]);
                    visited.Add((row+1, col));
                }

                if(col+1 < cols && !visited.Contains((row, col + 1)))
                {
                    que.Enqueue((matrix[row][col+1], row, col + 1), matrix[row][col+1]);
                    visited.Add((row, col+1));
                }


            }

            return result;
            
        }
    }
}
