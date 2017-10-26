using System;

namespace HW_1
{
    public class _2
    {
        public static int getEvensSum()
        {
            int result = 0;
            for (int i = 1; i <= 99; ++i)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        public static int getNEvens()
        {
            int result = 0;
            for (int i = 1; i <= 99; ++i)
            {
                if (i % 2 == 0)
                {
                    ++result;
                }
            }
            return result;
        }

        public static bool isPrime(uint num)
        {
            if (num == 0)
                return false;
            for (int i = 2; i <= num / 2; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static uint sqrt(uint n)
        {
            uint result = 0;
            while (result * result <= n)
            {
                ++result;
            }
            return result - 1;

        }

        public static uint sqrtBS(uint n)
        {
            uint left = 0;
            uint right = n + 1;
            while (left < right)
            {
                uint m = left + (right - left) / 2;
                if (m * m == n)
                {
                    return m;
                }

                if (m * m < n)
                {
                    left = m + 1;
                }
                else
                {
                    right = m;
                }
            }
            return left - 1;
        }

        public static ulong factorial(uint n)
        {
            if (n == 0) return 1;
            ulong result = 1;
            for (uint i = 2; i <= n; ++i)
            {
                result *= i;
            }
            return result;
        }

        public static int CalcDigits(int input)
        {
            int result = 0;
            while (input != 0)
            {
                result += input % 10;
                input /= 10;
            }
            return (result < 0 ? -result : result);
        }

        public static int getMirror(int n)
        {
            int result = 0;
            do
            {
                result = result * 10 + n % 10;
                n /= 10;
            } while (n != 0);
            return result;
        }
    }
}
