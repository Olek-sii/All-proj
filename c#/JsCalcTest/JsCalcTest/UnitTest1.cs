using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JsCalcTest
{
	[TestClass]
	public class TestWebDriver
	{
		static string _url = "file:///C:/Users/Student/Desktop/c%23/HW_2/calcJS2.html";
		static IWebDriver _driver;

		[ClassInitialize()]
		public static void ClassInit(TestContext tc) {
			_driver = new ChromeDriver();
			_driver.Url = _url;
		}

		[ClassCleanup()]
		public static void ClassCleanup() {
			_driver.Close();
		}


		[TestMethod]
		public void SimpleCheck()
		{
			Assert.AreEqual(true, _driver.FindElement(By.Id("1")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("2")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("3")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("4")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("5")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("6")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("7")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("8")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("9")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("0")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("+")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("-")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("*")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("/")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("0")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("res")).Displayed);
		}

		[DataTestMethod]
		[DataRow("1", "1")]
		[DataRow("2", "2")]
		[DataRow("3", "3")]
		[DataRow("4", "4")]
		[DataRow("5", "5")]
		[DataRow("6", "6")]
		[DataRow("7", "7")]
		[DataRow("8", "8")]
		[DataRow("9", "9")]
		[DataRow("0", "")]
		public void SimpleTest(string id, string expected)
		{
			_driver.FindElement(By.Id(id)).Click();
			string res = _driver.FindElement(By.Id("res")).GetAttribute("value");
			Assert.AreEqual(expected, res);
			_driver.Navigate().Refresh();
		}

		[DataTestMethod]
		[DataRow("1", "2", "12")]
		[DataRow("2", "2", "22")]
		[DataRow("3", "2", "32")]
		[DataRow("4", "2", "42")]
		[DataRow("5", "2", "52")]
		[DataRow("6", "2", "62")]
		[DataRow("7", "2", "72")]
		[DataRow("8", "2", "82")]
		[DataRow("9", "2", "92")]
		[DataRow("0", "2", "2")]
		public void ComplexTest(string id1, string id2, string expected)
		{
			_driver.FindElement(By.Id(id1)).Click();
			_driver.FindElement(By.Id(id2)).Click();
			string res = _driver.FindElement(By.Id("res")).GetAttribute("value");
			Assert.AreEqual(expected, res);
			_driver.Navigate().Refresh();
		}

		[DataTestMethod]
		[DataRow("7", "+", "2", "9")]
		[DataRow("8", "-", "2", "6")]
		[DataRow("9", "*", "6", "54")]
		[DataRow("4", "/", "2", "2")]
		[DataRow("4", "/", "0", "Infinity")]
		public void RealJob(string id1, string id2, string id3, string expected)
		{
			_driver.FindElement(By.Id(id1)).Click();
			_driver.FindElement(By.Id(id2)).Click();
			_driver.FindElement(By.Id(id3)).Click();
			_driver.FindElement(By.Id("=")).Click();
			string res = _driver.FindElement(By.Id("res")).GetAttribute("value");
			Assert.AreEqual(expected, res);
			_driver.Navigate().Refresh();
		}
	}
}
