using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasks
{
    public class Cicle
    {
        public static int GetNumberAPowerB(int a, int b)
        {
            int num_n = 1;

            if (b == 0)
            {
                return 1;
            }
            else
            {

                for (int i = 0; i < b; ++i)
                {
                    num_n *= a;
                }
                return num_n;
            }
        }

        public static int[] DivisionA(int a, int i)
        {
            int[] ar = new int[1000 / a];
            int j = 0;
            for (i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    ar[j++] = i; 
                }
                j++;
            }
            return ar;
        }

        public static int GetCountOfNumLessSquareA(int a)
        {
            int count = 0;

            for (int i = 0; i < a; i++)
            {
                if (i * i < a)
                {
                    count++;
                }
            }

            return count;
        }
        public static int GreatestDivisor(int a)
        {
            int greatestDiv = 0;

            for (int i = 1; i < a; i++)
            {
                if ((a % i == 0) && (i != a))
                {
                    greatestDiv = i;
                }
            }

            return greatestDiv;
        }

        public static int GetSumOfMultiplesOfSeven(int leftBord, int rightBord)
        {

            int sum = 0;

            for (int i = leftBord; i < rightBord; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int GetNFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return GetNFibonacciNumber(n - 1) + GetNFibonacciNumber(n - 2);
            }
        }

        public static int GreatestDivisorEuclidAlgorithm(int a, int b)
        {

            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public static int GetValueWithBinarySearch(int right)
        {
            if (right < 0)
            {
                throw new Exception("Must be a positiv number");
            }
            if (Math.Round(Math.Pow(right, 1.0 / 3), 10) % 1 != 0)
            {
                throw new Exception("Must be a whole");
            }

            int n = Convert.ToInt32(Math.Pow(right, 1.0 / 3));

            int mid = 0;
            int left = 0;
            while (mid != n)
            {
                mid = (left + right) / 2;
                if (mid > n)
                {
                    right = mid;
                }
                else if (mid < n)
                {
                    left = mid;
                }
            }

            return mid;
        }

        public static int GetNumberOfOddDigits(int n)
        {
            int cnt = 0;

            while (n != 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    cnt++;
                }
                n /= 10;
            }

            return n;
        }

        public static int GetMirrorOfNum(int num)
        {
            String mirror = String.Empty;
            while (num != 0)
            {
                mirror += num % 10;
                num /= 10;
            }

            return Convert.ToInt32(mirror);
        }

        public static int GetNumbersForWitchSumEvenNumericLessOdd(int a)
        {

            int value;
            int b;
            int count = 0;
            for (int i = 1; i < a; i++)
            {
                value = i;
                int sum1 = 0;
                int sum2 = 0;
                while (value != 0)
                {
                    b = value % 10;
                    value /= 10;
                    if (b % 2 == 1)
                    {
                        sum1 += b;
                    }
                    else
                    {
                        sum2 += b;
                    }
                }
                if (sum1 < sum2)
                {
                    ++count;
                }
            }
            return count;

        }

        public static bool GetNumbersSame(int OneNum, int TwoNum)
        {
            int temp;
            while ((OneNum != 0))
            {
                temp = TwoNum;
                while (temp != 0)
                {
                    if ((OneNum % 10) == (temp % 10))
                    {
                        return true;
                    }
                    temp /= 10;
                }
                OneNum /= 10;
            }
            return false;
        }
    }
}
