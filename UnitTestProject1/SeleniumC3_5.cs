using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace UnitTestProject1
{
	class SeleniumC3_5
	{
		ExtentReports extentReports = null;
		[OneTimeSetUp]
		public void ExtentStart()
		{
			extentReports = new ExtentReports();
			var htmlReporter = new ExtentHtmlReporter(@"C:\Users\levan\OneDrive\Desktop\UnitTestProject1\UnitTestProject1\ExtentReport\SeleniumC3_5.XTML");
			extentReports.AttachReporter(htmlReporter);
		}
		[OneTimeTearDown]
		public void ExtentClose()
		{
			extentReports.Flush();
		}
		[Test]
		public void Test1()
		{
			IWebDriver driver = null;
			ExtentTest extentTest = null;
			try
			{
				extentTest = extentReports.CreateTest("Test1").Info("Test Started");
				driver = new ChromeDriver();
				extentTest.Log(Status.Info, "Chrome Browser Launch");
				driver.Url = "https://facebook.com";
				IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
				emailTextField.SendKeys("Selenium C#");
				extentTest.Log(Status.Info, "Email ID Entered");
				driver.Quit();
				extentTest.Log(Status.Pass, "Test1 Passed");
			}
			catch (Exception ex)
			{
				extentTest.Log(Status.Fail, ex.ToString());
				throw;
			}
			finally
			{
				if (driver != null)
					driver.Quit();
			}
		}
		[Test]
		public void Test2()
		{
			ExtentTest extentTest = null;
			IWebDriver driver = null;
			try
			{
				extentTest = extentReports.CreateTest("Test2").Info("Test Started");
				driver = new ChromeDriver();
				extentTest.Log(Status.Info, "Chrome Browser Launch");
				driver.Url = "https://facebook.com";
				IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='eemail']"));
				emailTextField.SendKeys("Selenium C#");
				extentTest.Log(Status.Info, "Email ID Entered");
				driver.Quit();
				extentTest.Log(Status.Pass, "Test1 Passed");
			}
			catch (Exception ex)
			{
				extentTest.Log(Status.Fail, ex.ToString());
				throw;
			}
			finally
			{
				if (driver != null)
					driver.Quit();
			}
		}
	}
}
