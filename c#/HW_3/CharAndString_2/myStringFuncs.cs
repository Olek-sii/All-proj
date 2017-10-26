using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CharAndString_2
{
    public class myStringFuncs
    {
        //Дана строка, состоящая из слов, разделенных пробелами и знаками препинания.
        //Определить длину самого короткого слова.
        public static int ShortestWord(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Str is null or empty");
            }
            string[] words = Regex.Split(str, @"[\s\p{P}]");
            int res = words[0].Length;
            foreach (var item in words)
            {
                if (item == "")
                {
                    continue;
                }
                if (item.Length < res)
                {
                    res = item.Length;
                }
            }
            return res;
        }

        //Дан массив слов.Заменить последние три символа слов, имеющих заданную длину на символ "$"
        public static string[] ReplaceLast3(string[] arr, int wordLength)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    throw new ArgumentNullException();
                }
                if (arr[i].Length == wordLength)
                {
                    if (arr[i].Length <= 3)
                    {
                        arr[i] = arr[i].Remove(arr[i].Length - arr[i].Length, arr[i].Length) + "$";
                    }
                    else
                    {
                        arr[i] = arr[i].Remove(arr[i].Length - 3, 3) + "$";
                    }
                }
            }
            return arr;
        }

        //Добавить в строку пробелы после знаков препинания, если они там отсутствуют.

        public static string AddSpaces(string input)
        {
            //    string pattern = @"[\p{P}]\w+";

            //  Regex reg = new Regex(@"\p{P}\S");
            //string[] str_split = reg.Split(str);
            // reg.Replace(str, " ");
            if (input == null)
                throw new ArgumentNullException();

            List<char> checkSumbol = new List<char> { ',', '?', '!', '.' };

            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1 && checkSumbol.Contains(input[i]) && input[i + 1] != ' ')
                    input = input.Insert(i + 1, " ");
            }

            return input;
        }

        //Оставить в строке только один экземпляр каждого встречающегося символа.
        public static string MakeOneSym(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            List<char> els = new List<char>();
            string answ = "";
            foreach (char el in str)
            {
                if (!els.Contains(el))
                {
                    els.Add(el);
                    answ += el;
                }
            }
            return answ;
        }

        //Подсчитать количество слов во введенной пользователем строке.
        public static int WordsCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            string[] sp = str.Split(' ');
            int count = 0;
            foreach (string t in sp)
            {
                if (t.Length != 0)
                {
                    ++count;
                }
            }
            return count;
        }

        //Удалить из строки ее часть с заданной позиции и заданной длины.
        public static string MyDelete(string str, int pos, int length)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (pos + length > str.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            return str.Remove(pos, length);
        }
        // Перевернуть строку, т.е.последние символы должны стать первыми, а первые последними.
        public static string ReverseString(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            string answ = "";
            for (int i = str.Length - 1; i >= 0; --i)
            {
                answ += str[i];
            }
            return answ;
        }

        // В заданной строке удалить последнее слово
        public static string DeleteLastWord(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            str = str.TrimEnd(' ');
            str = str.Remove(str.LastIndexOf(' ') + 1);
            return str.Trim();
        }
    }
}
