using System;

namespace HW_1
{
    public class _1
    {
        public static int calculate(int a, int b)
        {
            int result = 0;
            if (a % 2 == 0)
            {
                result = a * b;
            }
            else
            {
                result = a + b;
            }
            return result;
        }

        public static int getQuadrant(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException();
            }
            int result = 0;
            if (x > 0)
            {
                if (y > 0)
                {
                    result = 1;
                }
                else if (y < 0)
                {
                    result = 4;
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    result = 2;
                }
                else if (y < 0)
                {
                    result = 3;
                }
            }
            return result;
        }

        public static int sumOnlyPositive(int a, int b, int c)
        {
            int result = 0;
            if (a > 0)
            {
                result += a;
            }
            if (b > 0)
            {
                result += b;
            }
            if (c > 0)
            {
                result += c;
            }
            return result;
        }

        public static int calculate(int a, int b, int c)
        {
            int result = 0;
            if (a * b * c > a + b + c)
            {
                result = a * b * c + 3;
            }
            else
            {
                result = a + b + c + 3;
            }
            return result;
        }

        public static char getNote(int rating)
        {
            if (rating < 0 || rating > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            char result = '0';
            if (rating >= 0 && rating <= 19)
            {
                result = 'F';
            }
            else if (rating >= 20 && rating <= 39)
            {
                result = 'E';
            }
            else if (rating >= 40 && rating <= 59)
            {
                result = 'D';
            }
            else if (rating >= 60 && rating <= 74)
            {
                result = 'C';
            }
            else if (rating >= 75 && rating <= 89)
            {
                result = 'B';
            }
            else if (rating >= 90 && rating <= 100)
            {
                result = 'A';
            }
            return result;
        }
    }
}