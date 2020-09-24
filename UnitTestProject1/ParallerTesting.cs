using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProject1.Utilities;

namespace UnitTestProject1
{
	[TestClass]
	public class ParallerTesting
	{
		IWebDriver _driverIn;
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod1()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod2()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod3()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod4()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}

		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod5()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod6()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod7()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod8()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod9()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
		[Test, Category("Uat Testing"), Category("Module1")]
		public void TestMethod10()
		{
			var driver = new BrowserUtiliti().intializer(_driverIn);
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='lastname']"));
			emailTextField.SendKeys("Selenium C#");
			driver.Close();
		}
	}
}
