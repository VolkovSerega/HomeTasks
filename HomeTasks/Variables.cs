using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
   public static class Variables
    {
        public static int EquationSolution(int a, int b)
        {
            if(b - a == 0)
            {
                throw new DivideByZeroException(" b - a  == 0  division by zero");
            }
            int x = ((5 * a) + (b * b)) / (b - a);
            return x;
        }

        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static int[] OutputResultAndRemainder(int a, int b)
        {
            
                if (b == 0)
                {
                    throw new DivideByZeroException(" b == 0  division by zero");
                }
                int division = a / b;
                int remainder = a % b;
            return new int[2] {division, remainder};
            }

        public static int CalculateLinearEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException(" a == 0  division by zero");
            }
            int x = (c / a) - (b / a);
            return x;
        }

        public static (int a, int b) GetStraightLineEquation(int X1, int Y1, int X2, int Y2)
        {
            if (X1 == X2)
            {
                throw new DivideByZeroException("X1 value should not be equal to X2");
            }

            int a = (Y2 - Y1) / (X2 - X1);
            int b = -(X1 * Y2 - X2 * Y1) / (X2 - X1);
           
            return (a, b);
        }
    }
    }

