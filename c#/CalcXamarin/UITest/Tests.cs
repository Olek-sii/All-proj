using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
	public class Tests
	{
		IApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			app = ConfigureApp
				.Android
				.InstalledApp("CalcXamarin.Android")
				.StartApp();
		}

		[TearDown]
		public void AfterEachTest()
		{
			//Environment.Exit(0);

		}


		[Test]
		[TestCase("1")]
		[TestCase("2")]
		[TestCase("3")]
		[TestCase("4")]
		[TestCase("5")]
		[TestCase("6")]
		[TestCase("7")]
		[TestCase("8")]
		[TestCase("9")]
		[TestCase("0")]
		public void TestSimple(string but)
		{
			app.Tap(c => c.Marked(but));
			AppResult[] results = app.Query(c => c.Marked("textResult"));
			Assert.AreEqual(but, results[0].Text);
		}

		[Test]
		[TestCase("1")]
		[TestCase("2")]
		[TestCase("3")]
		[TestCase("4")]
		[TestCase("5")]
		[TestCase("6")]
		[TestCase("7")]
		[TestCase("8")]
		[TestCase("9")]
		[TestCase("0")]
		[TestCase("-")]
		[TestCase("+")]
		[TestCase("=")]
		[TestCase("/")]
		[TestCase("*")]
		public void TestExist(string but)
		{
			AppResult[] results = app.Query(c => c.Marked(but));
			Assert.IsTrue(results.Length != 0);
		}

		[Test]
		[TestCase("1", "2", "12")]
		[TestCase("3", "4", "34")]
		[TestCase("5", "6", "56")]
		[TestCase("7", "8", "78")]
		[TestCase("9", "0", "90")]
		public void TestComplex(string but1, string but2, string res)
		{
			app.Tap(c => c.Marked(but1));
			app.Tap(c => c.Marked(but2));
			AppResult[] results = app.Query(c => c.Marked("textResult"));
			Assert.AreEqual(res, results[0].Text);
		}

		[Test]
		[TestCase("1", "2", "+", "3")]
		[TestCase("3", "4", "*", "12")]
		[TestCase("5", "6", "-", "-1")]
		[TestCase("8", "4", "/", "2")]
		public void TestComplex(string but1, string but2, string op, string res)
		{
			app.Tap(c => c.Marked(but1));
			app.Tap(c => c.Marked(op));
			app.Tap(c => c.Marked(but2));
			app.Tap(c => c.Marked("="));
			AppResult[] results = app.Query(x => x.Marked("textResult"));
			Assert.AreEqual(res, results[0].Text);
		}
	}
}