using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndString_2
{
    public class myConverter
    {
        public static string IntToStr(int n)
        {
            var chars = "0123456789ABCDEF".ToCharArray();
            var str = new char[32]; // maximum number of chars in any base
            var i = str.Length;
            bool isNegative = (n < 0);
            if (n <= 0) // handles 0 and int.MinValue special cases
            {
                str[--i] = chars[-(n % 10)];
                n = -(n / 10);
            }

            while (n != 0)
            {
                str[--i] = chars[n % 10];
                n /= 10;
            }

            if (isNegative)
            {
                str[--i] = '-';
            }

            return new string(str, i, str.Length - i);
        }


        public static string DoubleToString(double n)
        {
            string res = "";
            if (n < 0)
            {
                res += "-";
                n *= -1;
            }

            n = Math.Round(n, 3);
            n *= 1000;
            int x = Convert.ToInt32(n);

            int afterPoint = x % 1000;
            while (afterPoint > 0 && afterPoint % 10 == 0)
            {
                afterPoint /= 10;
            }

            int beforePoint = x / 1000;

            res += IntToStr(beforePoint) + (afterPoint > 0 ? "." + IntToStr(afterPoint) : "");

            return res;
        }


        public static int StrToInt(string str) //беззнаковые
        {
            int res = 0;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    throw new InvalidCastException();
                res *= 10;
                res += c - '0';
            }
            return res;
        }

        public static double StrToDouble(string str)
        {
            double result = 0.0;
            double scale = 0.0;
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    result = 10.0 * result + c - '0';
                    scale *= 10.0;
                }
                else if (c == '.') scale = 1.0F;
                else
                {
                    throw new InvalidCastException();
                }
            }
            result = result / (scale == 0.0 ? 1.0 : scale);
            return result;
        }

    }
}
