using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [DataTestMethod]
        [DataRow(1, "Sunday")]
        [DataRow(2, "Monday")]
        [DataRow(3, "Tuesday")]
        [DataRow(4, "Wednesday")]
        [DataRow(5, "Thursday")]
        [DataRow(6, "Friday")]
        [DataRow(7, "Saturday")]
        public void TestDayName(int input, string expected)
        {
            Assert.AreEqual(expected, HW_1._4.getDayName(input));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDayName0()
        {
            HW_1._4.getDayName(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDayName8()
        {
            HW_1._4.getDayName(8);
        }


        [DataTestMethod]
        [DataRow((ulong)0, "нуль")]
        [DataRow((ulong)1, "один")]
        [DataRow((ulong)2, "два")]
        [DataRow((ulong)3, "три")]
        [DataRow((ulong)4, "четыре")]
        [DataRow((ulong)5, "пять")]
        [DataRow((ulong)6, "шесть")]
        [DataRow((ulong)7, "семь")]
        [DataRow((ulong)8, "восемь")]
        [DataRow((ulong)9, "девять")]
        [DataRow((ulong)10, "десять")]
        [DataRow((ulong)11, "одиннадцать")]
        [DataRow((ulong)12, "двенадцать")]
        [DataRow((ulong)13, "тринадцать")]
        [DataRow((ulong)14, "четырнадцать")]
        [DataRow((ulong)15, "пятнадцать")]
        [DataRow((ulong)16, "шестнадцать")]
        [DataRow((ulong)17, "семнадцать")]
        [DataRow((ulong)18, "восемнадцать")]
        [DataRow((ulong)19, "девятнадцать")]
        [DataRow((ulong)20, "двадцать")]
        [DataRow((ulong)30, "тридцать")]
        [DataRow((ulong)40, "сорок")]
        [DataRow((ulong)50, "пятьдесят")]
        [DataRow((ulong)60, "шестьдесят")]
        [DataRow((ulong)70, "семьдесят")]
        [DataRow((ulong)80, "восемьдесят")]
        [DataRow((ulong)90, "девяносто")]
        [DataRow((ulong)100, "сто")]
        [DataRow((ulong)200, "двести")]
        [DataRow((ulong)300, "триста")]
        [DataRow((ulong)400, "четыреста")]
        [DataRow((ulong)500, "пятьсот")]
        [DataRow((ulong)600, "шестьсот")]
        [DataRow((ulong)700, "семьсот")]
        [DataRow((ulong)800, "восемьсот")]
        [DataRow((ulong)900, "девятьсот")]
        [DataRow((ulong)1000, "одна тысяча")]
        [DataRow((ulong)2000, "две тысячи")]
        [DataRow((ulong)5000, "пять тысяч")]
        [DataRow((ulong)1000000, "один миллион")]
        [DataRow((ulong)2000000, "два миллиона")]
        [DataRow((ulong)5000000, "пять миллионов")]
        [DataRow((ulong)1000000000, "один миллиард")]
        [DataRow((ulong)2000000000, "два миллиарда")]
        [DataRow((ulong)5000000000, "пять миллиардов")]

        public void TestNumConverter(ulong input, string expected)
        {
            Assert.AreEqual(expected, HW_1._4.convert(input));
        }

        [DataTestMethod]
        [DataRow("нуль", (ulong)0)]
        [DataRow("один", (ulong)1)]
        [DataRow("два", (ulong)2)]
        [DataRow("три", (ulong)3)]
        [DataRow("четыре", (ulong)4)]
        [DataRow("пять", (ulong)5)]
        [DataRow("шесть", (ulong)6)]
        [DataRow("семь", (ulong)7)]
        [DataRow("восемь", (ulong)8)]
        [DataRow("девять", (ulong)9)]
        [DataRow("десять", (ulong)10)]
        [DataRow("одиннадцать", (ulong)11)]
        [DataRow("двенадцать", (ulong)12)]
        [DataRow("тринадцать", (ulong)13)]
        [DataRow("четырнадцать", (ulong)14)]
        [DataRow("пятнадцать", (ulong)15)]
        [DataRow("шестнадцать", (ulong)16)]
        [DataRow("семнадцать", (ulong)17)]
        [DataRow("восемнадцать", (ulong)18)]
        [DataRow("девятнадцать", (ulong)19)]
        [DataRow("двадцать", (ulong)20)]
        [DataRow("тридцать", (ulong)30)]
        [DataRow("сорок", (ulong)40)]
        [DataRow("пятьдесят", (ulong)50)]
        [DataRow("шестьдесят", (ulong)60)]
        [DataRow("семьдесят", (ulong)70)]
        [DataRow("восемьдесят", (ulong)80)]
        [DataRow("девяносто", (ulong)90)]
        [DataRow("сто", (ulong)100)]
        [DataRow("двести", (ulong)200)]
        [DataRow("триста", (ulong)300)]
        [DataRow("четыреста", (ulong)400)]
        [DataRow("пятьсот", (ulong)500)]
        [DataRow("шестьсот", (ulong)600)]
        [DataRow("семьсот", (ulong)700)]
        [DataRow("восемьсот", (ulong)800)]
        [DataRow("девятьсот", (ulong)900)]
        [DataRow("одна тысяча", (ulong)1000)]
        [DataRow("две тысячи", (ulong)2000)]
        [DataRow("пять тысяч", (ulong)5000)]
        [DataRow("один миллион", (ulong)1000000)]
        [DataRow("два миллиона", (ulong)2000000)]
        [DataRow("пять миллионов", (ulong)5000000)]
        [DataRow("один миллиард", (ulong)1000000000)]
        [DataRow("два миллиарда", (ulong)2000000000)]
        [DataRow("пять миллиардов", (ulong)5000000000)]

        public void TestNumConverterRev(string input, ulong expected)
        {
            Assert.AreEqual(expected, HW_1._4.convert(input));
        }


        [DataTestMethod]
        [DataRow(0, 5, 0, -5, 10)]
        [DataRow(5, 0, -5, 0, 10)]
        [DataRow(0, 3, 4, 0, 5)]
        [DataRow(3, 3, 3, 3, 0)]
        public void TestDistance(int x1, int y1, int x2, int y2, double expected)
        {
            Assert.AreEqual(expected, HW_1._4.distanse(x1, y1, x2, y2));
        }
    }
}