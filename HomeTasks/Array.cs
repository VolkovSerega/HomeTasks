using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasks
{
    public class Array
    {
        public static int GetMinimalElementOfArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int MaximalElementOfArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int IndexOfMinimalElementOfArray(int[] array)
        {
            int minIndex = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (minIndex < array[i])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int IndexOfMaximalElementOfArray(int[] array)
        {
            int maxIdex = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (maxIdex < array[i])
                {
                    maxIdex = i;
                }
            }
            return maxIdex;
        }

        public static int SumOddIndexElemArray(int[] array)
        {
            int sumEven = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                sumEven += array[i];
            }
            return sumEven;
        }

        public static void ReversArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length / 2; ++i)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }

        public static int SumOddElemArray(int[] array)
        {
            int sumOdd = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] % 2 != 0)
                {
                    sumOdd += array[i];
                }
            }
            return sumOdd;
        }

        public static void SwapElemArray(int[] array)
        {
            int temp;
            if (array.Length % 2 == 0)
            {
                for (int i = 0; i < (array.Length / 2); ++i)
                {
                    temp = array[i];
                    array[i] = array[array.Length / 2 + i];
                    array[array.Length / 2 + i] = temp;
                }
            }
            else
            {
                for (int i = 0; i < (array.Length / 2); ++i)
                {
                    temp = array[i];
                    array[i] = array[array.Length / 2 + i + 1];
                    array[array.Length / 2 + i + 1] = temp;
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            int temp;
            int j;

            for (int i = 1; i <= array.Length - 1; i++)
            {
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        public static void SelectionSort(int[] array)
        {

            int temp;
            int maxIndex;
            for (int i = 0; i < array.Length; ++i)
            {
                maxIndex = i;
                for (int j = i; j < array.Length; ++j)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;

            }
        }
    }
}

