using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
   public static class Variables
    {
        public static int EquationSolution(int a, int b)
        {
           
            int x = ((5 * a) + (b * b)) / (b - a);
            return x;
        }

        public static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = a;
        }

        public static int[] ResultAndRemainder(int a, int b)
        {
            
                if (b == 0)
                {
                    throw new DivideByZeroException(" b == 0  division by zero");
                }
                int division = a / b;
                int remainder = a % b;
            return new int[2] {division, remainder};
            }

        public static int LinearEquation(int a, int b, int c)
        {
            int x = (c / a) - (b / a);
            return x;
        }

        public static string StraightLineEquation(int X1, int Y1, int X2, int Y2)
        {
            if (X1 == X2)
            {
                throw new DivideByZeroException(" Деление на ноль");
            }
            int a = (Y2 - Y1) / (X2 - X1);
            int b = -(X1 * Y2 - X2 * Y1) / (X2 - X1);
            Convert.ToString(a);
            Convert.ToString(b);
            return "Y" + a + "X" + b;



        }
    }
    }

