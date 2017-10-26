using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndString_2
{
    [TestClass]
    public class part3Tests
    {
        [DataTestMethod]
        [DataRow("Hello", 5)]
        [DataRow("Hello world", 5)]
        [DataRow("Hello this world", 4)]
        [DataRow("Hello this world nu", 2)]
        public void ShortestWord_TEST(string init, int expected)
        {
            Assert.AreEqual(expected, myStringFuncs.ShortestWord(init));
        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentException))]
        public void ShortestWord_TEST_EX(string init)
        {
            myStringFuncs.ShortestWord(init);
        }

        [DataTestMethod]
        [DataRow("Init", 3, "Init")]
        [DataRow("Init", 4, "I$")]
        [DataRow("Ini", 2, "Ini")]
        [DataRow("Ini", 3, "$")]
        [DataRow("Ini world le", 2, "Ini world $")]
        [DataRow("Ini world l", 1, "Ini world $")]
        [DataRow("Ini world len", 3, "$ world $")]
        public void ReplaceLast3_TEST(string init, int length, string expected)
        {
            string[] exp_Sp = expected.Split(' ');
            string[] act_Sp = myStringFuncs.ReplaceLast3(init.Split(' '), length);
            CollectionAssert.AreEqual(exp_Sp, act_Sp);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReplaceLast3_TEST_EX()
        {
            string[] exp = { null, "", "Hello" };
            myStringFuncs.ReplaceLast3(exp, 3);
        }

        [DataTestMethod]
        [DataRow("Hello,world!", "Hello, world!")]
        [DataRow("Hello, world!", "Hello, world!")]
        [DataRow("Hello,world!Its.Ok", "Hello, world! Its. Ok")]
        public void AddSpaces_TEST(string init, string expected)
        {
            Assert.AreEqual(expected, myStringFuncs.AddSpaces(init));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddSpaces_TEST_EX()
        {
            myStringFuncs.AddSpaces(null);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("ABC", "ABC")]
        [DataRow("Hello", "Helo")]
        [DataRow("Its ab big world", "Its abigworld")]
        public void MakeOneSym_TEST(string init, string expected)
        {
            Assert.AreEqual(expected, myStringFuncs.MakeOneSym(init));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MakeOneSym_TEST_EX()
        {
            myStringFuncs.MakeOneSym(null);
        }

        [DataTestMethod]
        [DataRow("", 0)]
        [DataRow("  ", 0)]
        [DataRow("One", 1)]
        [DataRow("One two", 2)]
        [DataRow("One two three", 3)]
        public void WordsCount_TEST(string init, int expected)
        {
            Assert.AreEqual(expected, myStringFuncs.WordsCount(init));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WordsCount_TEST_EX()
        {
            myStringFuncs.WordsCount(null);
        }

        [DataTestMethod]
        [DataRow("", 0, 0, "")]
        [DataRow("  ", 0, 2, "")]
        [DataRow("One", 1, 1, "Oe")]
        [DataRow("One two", 2, 3, "Onwo")]
        [DataRow("One two three", 4, 1, "One wo three")]
        public void MyDelete_TEST(string init, int pos,
            int length, string expected)
        {
            Assert.AreEqual(expected, myStringFuncs.MyDelete(init, pos, length));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MyDelete_TEST_NULL_EX()
        {
            myStringFuncs.MyDelete(null, 0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MyDelete_TEST_EX()
        {
            myStringFuncs.MyDelete("Hello", 3, 5);
        }

        [DataTestMethod]
        [DataRow("Hello", "olleH")]
        [DataRow("My Day", "yaD yM")]
        public void ReverseString_TEST(string init, string expected)
        {
            Assert.AreEqual(expected, myStringFuncs.ReverseString(init));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseString_TEST_EX()
        {
            myStringFuncs.ReverseString(null);
        }

        [DataTestMethod]
        [DataRow("Test", "")]
        [DataRow("Test method", "Test")]
        [DataRow("Test new method", "Test new")]
        public void DeleteLastWord_TEST(string init, string expected)
        {
            Assert.AreEqual(expected, myStringFuncs.DeleteLastWord(init));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteLastWord_TEST_EX()
        {
            myStringFuncs.DeleteLastWord(null);
        }
    }
}
