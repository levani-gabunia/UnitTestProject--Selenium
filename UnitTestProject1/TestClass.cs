using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProject1.BaseClass;
using System.Threading;

namespace UnitTestProject1
{
	[TestClass]
	public class TestClass : BaseTest
	{
		[Test,Category("Smoke")]//loginshi teqstis minicheba
		public void TestMethod1()
		{
			IWebElement emailTextField = _driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#"); 
		}
		[Test,Category("Regresion")] //firstnameshi teqstis minicheba/birthdates daseleqteba
		public void TestMethod2()
		{
			IWebElement emailTextField = _driver.FindElement(By.XPath(".//*[@name='firstname']"));
			emailTextField.SendKeys("Selenium C#");
			IWebElement monthTextSelect = _driver.FindElement(By.XPath(".//*[@id='month']"));
			SelectElement element = new SelectElement(monthTextSelect);
			element.SelectByIndex(2);
			element.SelectByText("Mar");
			element.SelectByValue("4");
			Thread.Sleep(3000);
		}
		[Test,Category("Smoke")]
		public void TestMethod3()
		{
			IWebElement emailTextField = _driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			Thread.Sleep(5000);
		}
	}
}
