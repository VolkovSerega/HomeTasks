using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    class TwoDimensionalArray
    {
        public static int GetMinValue(int[,] arr)
        {
            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }

                }
            }
            return min;

        }
        public static int GetMaxValue(int[,] arr)
        {
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }

                }
            }
            return max;

        }

        public static int[] GetMinIndexArray(int[,] arr)
        {
            int min = arr[0, 0];
            int[] minIndexArray = new int[2];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minIndexArray[0] = i;
                        minIndexArray[1] = j;

                    }

                }
            }
            return minIndexArray;
        }

        public static int[] GetMaxIndexArray(int[,] arr)
        {
            int max = arr[0, 0];
            int[] maxIndexArray = new int[2];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxIndexArray[0] = i;
                        maxIndexArray[1] = j;

                    }

                }
            }
            return maxIndexArray;
        }
        public static int ElementLargerThanNeighbors(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (AdditionOfNeighbors(array, i, j))
                        count++;
                }
            }
            return count;
        }
        public static bool AdditionOfNeighbors(int[,] array, int i, int j)
        {

            for (int di = -1; di <= 1; di++)
            {
                for (int dj = -1; dj <= 1; dj++)
                {
                    if ((i + di) >= 0 && (i + di) < array.GetLength(0) && (j + dj) > 0 && (j + dj) < array.GetLength(1) && !(di == 0 && dj == 0))
                    {
                        if (array[i, j] > array[i + di, j + dj])
                        {
                            return true;
                        }

                    }
                }

            }
            return false;

        }

        public static int[,] TransposeMatrix(int[,] m)
        {
            int rows = m.GetLength(0);
            int columns = m.GetLength(1);
            int[,] transposed = new int[columns, rows];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    transposed[c, r] = m[r, c];
                }
            }
            return transposed;
        }

    }
}




