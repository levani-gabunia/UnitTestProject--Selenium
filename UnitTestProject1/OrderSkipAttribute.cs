using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProject1.BaseClass;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Drawing;

namespace UnitTestProject1
{
	[TestFixture]
	public class OrderSkipAttribute
	{
		[Test,Order(2),Category("OrderSkipAttribute")] //orderi pirveli romeli gaushvas
		public void TestMethod1()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Url = "https://facebook.com";
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Order(0), Category("OrderSkipAttribute")]
		public void TestMethod2()
		{
			Assert.Ignore("Not Installed"); //ingori atributis
			IWebDriver driver = new FirefoxDriver();
			driver.Url = "https://facebook.com";
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Order(1),Category("OrderSkipAttribute")]
		public void TestMethod3()
		{
			Assert.Ignore("Localhost Problem");
			IWebDriver driver = new InternetExplorerDriver();
			driver.Url = "http://facebook.com";
			IWebElement emailTextField = driver.FindElement(By.Name(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
	}
}
