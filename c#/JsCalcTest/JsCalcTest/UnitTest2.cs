using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JsCalcTest {
	[TestClass]
	public class UnitTest2 {
		static string _url = "file:///C:/Users/Student/Desktop/c%23/HW_2/calcJS.html";
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
		public void SimpleCheck() {
			Assert.AreEqual(true, _driver.FindElement(By.Id("a")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("b")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("c")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("res")).Displayed);
			Assert.AreEqual(true, _driver.FindElement(By.Id("click")).Displayed);
		}

		[DataTestMethod]
		[DataRow("7", "+", "2", "9")]
		[DataRow("8", "-", "2", "6")]
		[DataRow("9", "*", "10", "90")]
		[DataRow("4", "/", "2", "2")]
		[DataRow("4", "/", "0", "Infinity")]
		public void RealJob(string id1, string id2, string id3, string expected) {
			_driver.FindElement(By.Id("a")).SendKeys(id1);
			_driver.FindElement(By.Id("c")).SendKeys(id2);
			_driver.FindElement(By.Id("b")).SendKeys(id3);
			_driver.FindElement(By.Id("click")).Click();
			string res = _driver.FindElement(By.Id("res")).GetAttribute("value");
			Assert.AreEqual(expected, res);
			_driver.Navigate().Refresh();
		}
	}
}
