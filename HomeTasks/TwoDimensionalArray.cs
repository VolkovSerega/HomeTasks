using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    public class TwoDimensionalArray
    {
        public static int GetMinValue(int[,] arr)
        {
            if (arr != null && arr.Length > 0)
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
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int GetMaxValue(int[,] arr)
        {
            if (arr != null && arr.Length > 0)
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
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int[] GetMinIndexArray(int[,] arr)
        {
            if (arr != null && arr.Length > 0)
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
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int[] GetMaxIndexArray(int[,] arr)
        {
            if (arr != null && arr.Length > 0)
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
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int FindingNumberMaxElementsSecond(int[,] array)
        {
            if (array != null && array.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        bool elementmax = true;
                        for (int di = -1; di <= 1; di++)
                        {
                            for (int dj = -1; dj <= 1; dj++)
                            {
                                if ((i + di) >= 0 && (i + di) < array.GetLength(0) && (j + dj) >= 0 && (j + dj) < array.GetLength(1) && !(di == 0 && dj == 0))
                                {
                                    if (array[i, j] > array[i + di, j + dj])
                                    {

                                    }
                                    else
                                    {
                                        elementmax = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (elementmax)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int[,] TransposeMatrix(int[,] m)
        {
            if (m != null && m.Length > 0)
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
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }


        }
    }
}