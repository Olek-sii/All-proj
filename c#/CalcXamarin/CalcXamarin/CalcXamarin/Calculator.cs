using System;

namespace CalcXamarin
{
    public class Calc
    {
        public static double calculate(double a, double b, char c)
        {
            double result = 0;
            switch (c)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
            }
            return result;
        }
    }
}

