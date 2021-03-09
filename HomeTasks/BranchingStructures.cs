using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasks
{
   public class BranchingStructures
    {
        public static int CalculationIf(int a, int b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }

        public static int LocationInQuarter(int x, int y)
        {
            int result;
            if (y > 0)
            {
                if (x > 0)
                {
                    result = 1;
                }
                else // x < 0                
                {
                    result = 2;
                }
            }
            else // y < 0
            {
                if (x < 0)
                {
                    result = 3;
                }
                else // x > 0                
                {
                    result = 4;
                }
            }

            return result;
        }

        public static int[] SortingThreeElements(int a, int b, int c)
        {
            int temp = 0;
            if (a > b) { temp = a; a = b; b = temp; }
            if (a > c) { temp = a; a = c; c = temp; }
            if (b > c) { temp = b; b = c; c = temp; }
            return new int[3] { a, b, c };
        }

        public static double[] QadraticEquation(int a, int b, int c)
        {

            if (a == 0)
            {
                throw new DivideByZeroException("a==0");
            }

            double[] result;
            var d = b * b - 4 * a * c;
            if (d == 0)
            {
                result = new double[1];
                result[0] = -b / 2.0 / a;
            }
            else if (d > 0)
            {
                result = new double[2];
                result[0] = (-b - Math.Sqrt(d)) / 2 / a;
                result[1] = -b + Math.Sqrt(d) / 2 / a;
            }

            else
            {
                throw new Exception("d < 0");
            }

            return result;
        }

        public static String GetNumberWriting(int num)
        {
            if (num < 10 || num >= 100)
            {
                throw new Exception("Must be a two-digit positive number");
            }
            String numWriting = String.Empty;
            int leftPart, rightPart;

            leftPart = num / 10;
            rightPart = num % 10;

            if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        numWriting += "Десять";
                        break;
                    case 11:
                        numWriting += "Одинадцать";
                        break;
                    case 12:
                        numWriting += "Двенадцать";
                        break;
                    case 13:
                        numWriting += "Тринадцать";
                        break;
                    case 14:
                        numWriting += "Четырнадцать";
                        break;
                    case 15:
                        numWriting += "Пятнадцать";
                        break;
                    case 16:
                        numWriting += "Шестнадцать";
                        break;
                    case 17:
                        numWriting += "Семнадцать";
                        break;
                    case 18:
                        numWriting += "Восемнадцать";
                        break;
                    case 19:
                        numWriting += "Девятнадцать";
                        break;
                }
            }
            else
            {
                switch (leftPart)
                {
                    case 2:
                        numWriting += "Двадцать ";
                        break;
                    case 3:
                        numWriting += "Тридцать ";
                        break;
                    case 4:
                        numWriting += "Сорок ";
                        break;
                    case 5:
                        numWriting += "Пятдесят ";
                        break;
                    case 6:
                        numWriting += "Шестьдесят ";
                        break;
                    case 7:
                        numWriting += "Семьдесят ";
                        break;
                    case 8:
                        numWriting += "Восемьдесят ";
                        break;
                    case 9:
                        numWriting += "Девяносто ";
                        break;
                }
                switch (rightPart)
                {
                    case 1:
                        numWriting += "один ";
                        break;
                    case 2:
                        numWriting += "два ";
                        break;
                    case 3:
                        numWriting += "три ";
                        break;
                    case 4:
                        numWriting += "четыре ";
                        break;
                    case 5:
                        numWriting += "пять ";
                        break;
                    case 6:
                        numWriting += "шесть ";
                        break;
                    case 7:
                        numWriting += "семь ";
                        break;
                    case 8:
                        numWriting += "восемь ";
                        break;
                    case 9:
                        numWriting += "девять ";
                        break;
                }
            }

            return numWriting;
        
    

        }

    }

} 
