using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 случайных чисел:");
            Print10Randoms();

            Console.WriteLine("случайное число: ");
            PrintRandom();

            Console.WriteLine("10 случайных чисел, каждое в диапазоне от 0 до 10:");
            Print10RandomsIn0_10();

            Console.WriteLine("10 случайных чисел, каждое в диапазоне от 20 до 50:");
            Print10RandomsIn20_50();

            Console.WriteLine("10 случайных чисел, каждое в диапазоне от -10 до 10:");
            Print10RandomsIn10_10();

            Console.WriteLine("случайное количество(в диапазоне от 3 до 15) случайных чисел, каждое в диапазоне от -10 до 35:");
            PrintRandomOfRandoms();
        }

        //1.Вывести на консоль 10 случайных чисел.
        public static void Print10Randoms()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat("{0}, ", rnd.Next());
            }
            sb.Length -= 2;
            Console.WriteLine(sb);
        }

        //2.	Вывести на консоль случайное число.
        public static void PrintRandom()
        {
            Random random = new Random();
            Console.WriteLine(random.Next());
        }

        //3.	Вывести на консоль 10 случайных чисел, каждое в диапазоне от 0 до 10.
        public static void Print10RandomsIn0_10()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat("{0}, ", rnd.Next(0, 10));
            }
            sb.Length -= 2;
            Console.WriteLine(sb);
        }

        //4.	Вывести на консоль 10 случайных чисел, каждое в диапазоне от 20 до 50.
        public static void Print10RandomsIn20_50()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat("{0}, ", rnd.Next(20, 50));
            }
            sb.Length -= 2;
            Console.WriteLine(sb);
        }
        //5.	Вывести на консоль 10 случайных чисел, каждое в диапазоне от -10 до 10.
        public static void Print10RandomsIn10_10()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat("{0}, ", rnd.Next(-10, 10));
            }
            sb.Length -= 2;
            Console.WriteLine(sb);
        }
        //6.	Вывести на консоль случайное количество(в диапазоне от 3 до 15) случайных чисел, каждое в диапазоне от -10 до 35.
        public static void PrintRandomOfRandoms()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            int times = rnd.Next(3, 15);
            for (int i = 0; i < times; i++)
            {
                sb.AppendFormat("{0}, ", rnd.Next(-10, 35));
            }
            sb.Length -= 2;
            Console.WriteLine(sb);
        }

    }
}
