using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasks
{
    public class Array
    {
        public static int GetMinimalElementOfArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int GetMaximalElementOfArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int GetIndexOfMinimalElementOfArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int min = array[0];
                int index = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                        index = i;
                    }
                }
                return index;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int GetIndexOfMaximalElementOfArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int GetSumOddIndexElemArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int sumEven = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sumEven += array[i];
                    }
                }
                return sumEven;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int[] GetReversArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp;
                    temp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
                }
                return array;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int GetSumOddElemArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int sumOdd = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        sumOdd++;
                    }
                }
                return sumOdd;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }

        public static int[] SwapElemArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int temp;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    temp = array[i];
                    array[i] = array[i + array.Length / 2 + array.Length % 2];
                    array[i + array.Length / 2 + array.Length % 2] = temp;
                }
                return array;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
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

        public static int[] SelectionSort(int[] array)
        {

            if (array != null && array.Length != 0)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        }
    }


