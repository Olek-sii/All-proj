using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAlphabetUpper();
            PrintAlphabetReverse();
            PrintAlphabetRus();
            PrintDigits();
            PrintASCII();
        }

        public static void PrintAlphabetUpper()
        {
            StringBuilder sb = new StringBuilder();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                sb.AppendFormat("{0} ", i);
            }
            Console.WriteLine(sb);
        }
        public static void PrintAlphabetReverse()
        {
            StringBuilder sb = new StringBuilder();
            for (char i = 'z'; i >= 'a'; i--)
            {
                sb.AppendFormat("{0} ", i);
            }
            Console.WriteLine(sb);
        }

        public static void PrintAlphabetRus()
        {
            StringBuilder sb = new StringBuilder();
            for (char i = (char)1072; i < 1072 + 32; i++)
            {
                sb.AppendFormat("{0} ", i);
            }
            Console.WriteLine(sb);
        }

        public static void PrintDigits()
        {
            StringBuilder sb = new StringBuilder();
            for (char i = '0'; i <= '9'; i++)
            {
                sb.AppendFormat("{0} ", i);
            }
            Console.WriteLine(sb);
        }

        public static void PrintASCII()
        {
            StringBuilder sb = new StringBuilder();
            for (char i = (char)0; i < 256; i++)
            {
                sb.AppendFormat("{0} ", i);
            }
            Console.WriteLine(sb);
        }
    }
}
