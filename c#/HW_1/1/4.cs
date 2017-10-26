using System;

namespace HW_1
{
    public class _4
    {
        public static string getDayName(int v)
        {
            if (v <= 0 || v >= 8)
            {
                throw new ArgumentOutOfRangeException();
            }
            string[] days = {
                "", "Sunday", "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday"
            };
            return days[v];
        }

        public static double distanse(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public static string convert(ulong v)
        {
            if (v == 0) return "нуль";
            string result = "";
            uint exp3 = 0;
            while (v != 0)
            {
                string currentNum =
                    getHundreds(v % 1000) +
                    getDozens(v % 1000) +
                    getUnits(v % 1000, exp3 != 1);

                result = string.Concat(
                    (currentNum == "" ? "" : currentNum + " " + getPostfix(v, exp3) + " "),
                    result
                );
                v /= 1000;
                ++exp3;
            };
            result = result.Trim();
            return result;
        }

        public static ulong convert(string v)
        {
            if (v == "нуль") return 0;
            ulong result = 0;
            string[] parts = v.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            int exp3 = 0;
            bool skipUnits = false;
            for (int i = 0; i < parts.Length; ++i)
            {
                int index = getIndexByValue(_postfixs, parts[i]);
                if (index != -1)
                {
                    if (exp3 == 0)
                    {
                        result *= (ulong)Math.Pow(1000, index);
                        exp3 = index;
                    }
                }
                else
                {
                    if (count % 3 == 0)
                    {
                        skipUnits = false;
                        if (exp3 > 0) exp3--;
                        index = getIndexByValue(_hundreds, parts[i]);
                    }
                    else if (count % 3 == 1)
                    {
                        index = getIndexByValue(_dozens2to9, parts[i]);
                        if (index == -1)
                        {
                            index = getIndexByValue(_dozens1, parts[i]);
                            if (index != -1)
                            {
                                index += 10;
                                skipUnits = true;
                            }
                        }
                    }
                    else
                    {
                        if (skipUnits == false)
                        {
                            index = getIndexByValue(_unitsFem, parts[i]);
                            if (index == -1)
                            {
                                index = getIndexByValue(_unitsMas, parts[i]);
                            }
                            if (index == -1)
                            {
                                index = getIndexByValue(_units, parts[i]);
                                if (index != -1)
                                {
                                    index += 3;
                                }
                            }
                        }
                    }

                    if (index == -1)
                    {
                        --i;
                    }
                    else
                    {
                        if (index >= 10)
                        {
                            result = result + (ulong)index * (ulong)Math.Pow(10, exp3 * 3);
                        }
                        else
                        {
                            result = result + (ulong)index * (ulong)Math.Pow(10, 2 - count % 3 + exp3 * 3);
                        }
                    }
                    ++count;
                    if (count > 12)
                    {
                        throw new ArgumentException();
                    }
                }
            }
            return result;
        }

        private static int getIndexByValue(string[] source, string value)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        private static int getIndexByValue(string[,] source, string value)
        {
            int result = 0;
            foreach (string str in source)
            {
                if (str == value)
                {
                    return result / 3;
                }
                ++result;
            }
            return -1;
        }

        private static string getUnits(ulong v, bool isMas)
        {
            string result = "";
            if (v / 10 % 10 != 1)
            {
                if (v % 10 < 3)
                {
                    if (isMas)
                    {
                        result = _unitsMas[v % 10];
                    }
                    else
                    {
                        result = _unitsFem[v % 10];
                    }
                }
                else
                {
                    result = _units[v % 10 - 3];
                }
            }
            return result;
        }

        private static string getDozens(ulong v)
        {
            string result = "";
            if (v / 10 % 10 == 1)
            {
                result = _dozens1[v % 10];
            }
            else
            {
                result = _dozens2to9[v / 10 % 10];
            }
            return result;
        }

        private static string getHundreds(ulong v)
        {
            string result = _hundreds[v / 100];
            return result;
        }

        private static string getPostfix(ulong v, uint exp3)
        {
            string result = "";
            if (v / 10 % 10 == 1)
            {
                result = _postfixs[exp3, 0];
            }
            else
            {
                switch (v % 10)
                {
                    case 1: result = _postfixs[exp3, 1]; break;

                    case 2:
                    case 3:
                    case 4: result = _postfixs[exp3, 2]; break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 0: result = _postfixs[exp3, 0]; break;
                }
            }
            return result;
        }

        private static string[,] _postfixs = {
            { "", "", "" },
            { "тысяч", "тысяча", "тысячи" },
            { "миллионов", "миллион", "миллиона" },
            { "миллиардов", "миллиард", "миллиарда" }
        };

        private static string[] _hundreds = {
            "", "сто", "двести", "триста", "четыреста", "пятьсот",
            "шестьсот", "семьсот", "восемьсот", "девятьсот"
        };

        private static string[] _dozens1 = {
            "десять", "одиннадцать", "двенадцать", "тринадцать",
            "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать",
            "восемнадцать", "девятнадцать"
        };

        private static string[] _dozens2to9 = {
            "", "", "двадцать", "тридцать", "сорок", "пятьдесят",
            "шестьдесят", "семьдесят", "восемьдесят", "девяносто"
        };

        private static string[] _units = {
            "три", "четыре", "пять", "шесть",
            "семь", "восемь", "девять"
        };

        private static string[] _unitsFem = { "", "одна", "две" };
        private static string[] _unitsMas = { "", "один", "два" };
    }
}
